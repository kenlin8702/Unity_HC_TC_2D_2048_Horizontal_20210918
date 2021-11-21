using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 認識二維陣列
/// </summary>
public class Learn2DArray : MonoBehaviour {
    public int[] numbers = { 1, 7, 10, 17, 50 };

    public int[,] blocks = { { 2, 4 }, { 6, 8 } };

    public string[,] objects = new string[4, 6];

    public int[,] scores = { { 20, 60 }, { 70, 50 }, { 55, 28 } };
 
    // Start is called before the first frame update
    void Start()
    {
        print(blocks[0, 0]);

        print("二維陣列第0欄第一列:" + blocks[1, 0]);
        blocks[1, 0] = 7;
        print("二維陣列第0欄第一列:" + blocks[1, 0]);

        print("二維陣列的第一維度長度:" + scores.GetLength(0));

        print("二維陣列的第二維度長度:" + scores.GetLength(1));

        string result = "";
        for(int i = 0; i < scores.GetLength(0); i++) {
            for(int j = 0; j< scores.GetLength(1); j++) {
                result += scores[i, j] + "|";
            }
            result += "\n";
        }
        print(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
