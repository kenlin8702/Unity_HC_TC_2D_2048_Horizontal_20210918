using UnityEngine.UI;
using UnityEngine;
using System.Linq;


public class System2048 : MonoBehaviour
{
    [Header("空白區塊")]
    public Transform[] EmptyBlock;
    [Header("方塊")]
    public GameObject goblocks;
    [Header("畫布")]
    public Transform v2Canvas;

    [SerializeField]
    private Direction dir;


    private Vector3 downPos;

    private Vector3 upPos;

    private bool isMouseDown;

    BlockData[,] blocks = new BlockData[1, 4];
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
        switch (dir) {
            case Direction.Right:
                break;
            case Direction.Left:
                bool moveFinally = false;
                for (int i = 0; i < blocks.GetLength(0); i++) {
                    for(int j = 0;j < blocks.GetLength(1); j++) {

                        BlockData blockOriginal = new BlockData();
                        BlockData blockCheck = new BlockData();
                        bool canMove = false;
                        bool canMerge = false;
                        blockOriginal = blocks[i, j];
                        if (blockOriginal.number == 0) continue;
                        
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
                            }
                        }
                        if (canMove) {
                            blockOriginal.goBlocks.transform.position = blockCheck.v2Position;


                            if (canMerge) {
                                blockCheck.number = blockCheck.number * 2 ;

                                Destroy(blockOriginal.goBlocks);
                                blockCheck.goBlocks.transform.Find("數字").GetComponent<Text>().text = blockCheck.number.ToString();
                            } else {
                                blockCheck.number = blockOriginal.number;
                                blockCheck.goBlocks = blockOriginal.goBlocks;
                            }
                            blockOriginal.number = 0;
                            blockOriginal.goBlocks = null;
                        }
                    }
                }
                if (moveFinally) GenerateNumber(); //如果有移動才生成。
                printData();
                break;
            case Direction.Up:
                break;
            case Direction.Down:
                break;
        }
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