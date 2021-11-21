using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
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
        #region 存取
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
        #endregion

        #region 資料搜尋
        var NumberGreaterTen =
                from int n in numbers
                where n >= 10
                select n;
        #endregion

        print("大於10的數字總共有" + NumberGreaterTen.Count() + "筆");

        for(int i= 0;i < NumberGreaterTen.Count(); i++) {
            print(">= 10 的數字:"+NumberGreaterTen.ToArray()[i]);
        }

        var nopass =
                from int n in scores
                where n < 60
                orderby n descending
                select n;
        for(int i= 0;i < nopass.Count(); i++) {
            print("不及格的分數有:" + nopass.ToArray()[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
