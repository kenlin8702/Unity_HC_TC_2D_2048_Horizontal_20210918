using System.Collections;
using System.Collections.Generic;
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
    void Update()
    {
        
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
        if (Random.Range(0, 2) ==0) {
            randomblock.number = 2;
        } else {
            randomblock.number = 4;
        }
        

        GameObject temp = Instantiate(goblocks, v2Canvas);
        temp.transform.position = randomblock.v2Position;
        randomblock.goBlocks = temp;

    }


}
public enum Direction {
    None, Right, Left, Up, Down
}