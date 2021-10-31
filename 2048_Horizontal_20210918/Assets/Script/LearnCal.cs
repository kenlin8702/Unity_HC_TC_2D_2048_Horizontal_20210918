using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCal : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        #region 指定運算子
        a = 10;
        b = 3;
        #endregion

        #region 數學運算子
        // + - * / %
        print("加法：" + (a + b)); // 13
        print("減法：" + (a - b)); // 7
        print("乘法：" + (a * b)); // 30
        print("除法：" + (a / b)); // 3.33333
        print("餘數除法：" + (a % b)); // 1

        c = c + 1;
        c++;

        hp = hp + 10;
        hp += 10; //+= -= *= /= %=
        #endregion

        #region 比較運算子

        // > < >= <= == !=
        print(" a > b " + (a > b));
        print(" a < b " + (a < b));
        print(" a >= b " + (a >= b));
        print(" a <= b " + (a <= b));
        print(" a == b " + (a == b));
        print(" a != b " + (a != b));

        #endregion

        #region 邏輯運算子
        bool t = true;
        bool f = false;
        //只要有一個f 就是 f;
        print("t && t " + (t && t));
        print("t && f " + (t && f));
        print("f && t " + (f && t));
        print("f && f " + (f && f));
        //只要有一個t 就是 t;
        print("t || t " + (t || t));
        print("t || f " + (t || f));
        print("f || t " + (f || t));    
        print("f || f " + (f || f));
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
