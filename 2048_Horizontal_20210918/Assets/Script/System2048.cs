using UnityEngine.UI;
using UnityEngine;
using System.Linq;
using UnityEngine.Events;//引用Unity 事件命名空間

public class System2048 : MonoBehaviour
{
    [Header("空白區塊")]
    public Transform[] EmptyBlock;
    [Header("方塊")]
    public GameObject goblocks;
    [Header("畫布")]
    public Transform v2Canvas;
    [Header("數字相同合併事件")]
    public UnityEvent onMerging;

    [SerializeField]
    private Direction dir;


    private Vector3 downPos;

    private Vector3 upPos;

    private bool isMouseDown;

    BlockData[,] blocks = new BlockData[4, 4];
    // Start is called before the first frame update
    void Start()
    {
        int rrs = Random.Range(0, 10000000);
        Random.InitState(rrs);
        Initialize();
        Debug.Log(rrs);
    }

    // Update is called once per frame
    void Update() {
        checkDirection();
    }
    void Initialize() {
        for(int i= 0;i < blocks.GetLength(0); i++) {
            for(int j = 0; j < blocks.GetLength(1); j++) {
                blocks[i, j] = new BlockData();
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = EmptyBlock[i * blocks.GetLength(1) + j].position;
            }
        }
        GenerateNumber();
        GenerateNumber();
        printData();

    }
    void checkDirection() {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
            dir = Direction.Up;
            checkAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
            dir = Direction.Down;
            checkAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            dir = Direction.Left;
            checkAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
            dir = Direction.Right;
            checkAndMoveBlock();
        }

        if(!isMouseDown && Input.GetKeyDown(KeyCode.Mouse0)) {
            
            isMouseDown = true;
            downPos = Input.mousePosition;
            print("按下座標："+downPos);
        }
        if(isMouseDown && Input.GetKeyUp(KeyCode.Mouse0)) {
            
            
            isMouseDown = false;
            upPos = Input.mousePosition;
            print("放開座標："+upPos);

            Vector3 directionValue = upPos - downPos;
            print("向量值：" + directionValue);

            print("轉換後值" + directionValue.normalized);
            directionValue = directionValue.normalized;
            float xAbs = Mathf.Abs(directionValue.x);
            float yAbs = Mathf.Abs(directionValue.y);

            if(xAbs > yAbs) {
                if(directionValue.x > 0) {
                    dir = Direction.Right;
                } else {
                    dir = Direction.Left;
                }

            } else {
                if(directionValue.y > 0) {
                    dir = Direction.Up;
                } else {
                    dir = Direction.Down;
                }
            }
            checkAndMoveBlock();
        }
    }
    void checkAndMoveBlock() {
        BlockData blockOriginal = new BlockData();
        BlockData blockCheck = new BlockData();
        bool canMove = false;
        bool canMerge = false;
        bool moveFinally = false;
        switch (dir) {
            case Direction.Right:
                for (int i = 0; i < blocks.GetLength(0); i++) {
                    for (int j = blocks.GetLength(1) - 2; j >= 0; j--) {
                        blockOriginal = blocks[i, j];
                        if (blockOriginal.number == 0) continue;

                        for (int k = j + 1; k < blocks.GetLength(1); k++) {
                            
                            if (blocks[i, k].number == 0) {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                moveFinally = true;
                            } else if (blockOriginal.number == blocks[i, k].number) {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                canMerge = true;
                                moveFinally = true;
                            } else if (blockOriginal.number != blocks[i, k].number && blocks[i,k].number != 0) {
                                break;
                            }
                        }
                        if (canMove) {
                            MoveBlock(blockOriginal, blockCheck, canMerge);
                            canMove = false;
                            canMerge = false;
                        }
                    }
                }
                break;
            case Direction.Left:
                for (int i = 0; i < blocks.GetLength(0); i++) {
                    for (int j = 1;j < blocks.GetLength(1); j++) {
                        blockOriginal = blocks[i, j];
                        if (blockOriginal.number == 0 ) continue;
                        
                        for(int k = j - 1; k >= 0; k--) {
                            if (blocks[i,k].number == 0) {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                moveFinally = true;
                            }else if(blockOriginal.number == blocks[i, k].number) {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                canMerge = true;
                                moveFinally = true;
                            } else if (blockOriginal.number != blocks[i, k].number && blocks[i, k].number != 0) {
                                break;
                            }
                        }
                        if (canMove) {
                            MoveBlock(blockOriginal, blockCheck, canMerge);
                            canMove = false;
                            canMerge = false;
                        }
                    }
                }
                break;
            case Direction.Up:
                for (int i = 0; i < blocks.GetLength(1); i++) {
                    for (int j = 1; j < blocks.GetLength(0); j++) {
                        blockOriginal = blocks[j, i];
                        if (blockOriginal.number == 0) continue;

                        for (int k = j - 1; k >= 0; k--) {
                            if (blocks[k, i].number == 0) {
                                blockCheck = blocks[k, i];
                                canMove = true;
                                moveFinally = true;
                            } else if (blockOriginal.number == blocks[k, i].number) {
                                blockCheck = blocks[k, i];
                                canMove = true;
                                canMerge = true;
                                moveFinally = true;
                            } else if (blockOriginal.number != blocks[k, i].number && blocks[k,i].number != 0) {
                                break;
                            }
                        }
                        if (canMove) {
                            MoveBlock(blockOriginal, blockCheck, canMerge);
                            canMove = false;
                            canMerge = false;
                        }
                    }
                }
                break;
            case Direction.Down:
                for (int i = 0; i < blocks.GetLength(1); i++) {
                    for (int j = blocks.GetLength(0) - 2; j >= 0; j--) {
                        blockOriginal = blocks[j, i];
                        if (blockOriginal.number == 0) continue;

                        for (int k = j + 1; k < blocks.GetLength(0); k++) {

                            if (blocks[k, i].number == 0) {
                                blockCheck = blocks[k, i];
                                canMove = true;
                                moveFinally = true;
                            } else if (blockOriginal.number == blocks[k, i].number) {
                                blockCheck = blocks[k, i];
                                canMove = true;
                                canMerge = true;
                                moveFinally = true;
                            } else if (blockOriginal.number != blocks[k, i].number && blocks[k,i].number != 0) {
                                break;
                            }
                        }
                        if (canMove) {
                            MoveBlock(blockOriginal, blockCheck, canMerge);
                            canMove = false;
                            canMerge = false;
                        }
                    }
                }
                break;
        }
        if (moveFinally) GenerateNumber(); //如果有移動才生成。
        printData();
    }
    private void MoveBlock(BlockData blockOriginal,BlockData blockCheck, bool canMerge) {
        blockOriginal.goBlocks.transform.position = blockCheck.v2Position;

        if (canMerge) {
            blockCheck.number = blockCheck.number * 2;

            Destroy(blockOriginal.goBlocks);
            blockCheck.goBlocks.transform.Find("數字").GetComponent<Text>().text = blockCheck.number.ToString();

            onMerging.Invoke();
        } else {
            blockCheck.number = blockOriginal.number;
            blockCheck.goBlocks = blockOriginal.goBlocks;
        }
        blockOriginal.number = 0;
        blockOriginal.goBlocks = null;
    }
    void printData() {
        string result = "";
        for (int i = 0; i < blocks.GetLength(0); i++) {
            for (int j = 0; j < blocks.GetLength(1); j++) {
                result +="編號(" + i + "," + j + ")的數字為<color=red>" + blocks[i, j].number + "</color>" + blocks[i,j].v2Position + "|";
            }
            result += "\n";
        }
        Debug.Log(result);
    }
    void GenerateNumber() {
        var equalZero =
            from BlockData result in blocks
            where result.number == 0
            select result;

        print("目前有" + equalZero.Count() + "個數字為0的方塊");

        int rnd = Random.Range(0, equalZero.Count());
        print("選取第" + rnd + "個");
        BlockData Selected = equalZero.ToArray()[rnd];
        BlockData randomblock =  blocks[Selected.v2Index.x, Selected.v2Index.y];
        if (Random.Range(0, 4) ==0) {
            randomblock.number = 2;
        } else {
            randomblock.number = 2;
        }
        

        GameObject temp = Instantiate(goblocks, v2Canvas);
        temp.transform.position = randomblock.v2Position;
        randomblock.goBlocks = temp;

    }


}
public enum Direction {
    None, Right, Left, Up, Down
}