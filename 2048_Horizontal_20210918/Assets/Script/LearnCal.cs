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
        #region ���w�B��l
        a = 10;
        b = 3;
        #endregion

        #region �ƾǹB��l
        // + - * / %
        print("�[�k�G" + (a + b)); // 13
        print("��k�G" + (a - b)); // 7
        print("���k�G" + (a * b)); // 30
        print("���k�G" + (a / b)); // 3.33333
        print("�l�ư��k�G" + (a % b)); // 1

        c = c + 1;
        c++;

        hp = hp + 10;
        hp += 10; //+= -= *= /= %=
        #endregion

        #region ����B��l

        // > < >= <= == !=
        print(" a > b " + (a > b));
        print(" a < b " + (a < b));
        print(" a >= b " + (a >= b));
        print(" a <= b " + (a <= b));
        print(" a == b " + (a == b));
        print(" a != b " + (a != b));

        #endregion

        #region �޿�B��l
        bool t = true;
        bool f = false;
        //�u�n���@��f �N�O f;
        print("t && t " + (t && t));
        print("t && f " + (t && f));
        print("f && t " + (f && t));
        print("f && f " + (f && f));
        //�u�n���@��t �N�O t;
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
