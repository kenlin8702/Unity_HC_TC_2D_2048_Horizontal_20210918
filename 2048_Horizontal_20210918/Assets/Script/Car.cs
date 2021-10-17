using System;
using UnityEngine;


//class類別藍圖
public class Car : MonoBehaviour
{
    #region 四大類型
    [Header("這是CC數"),Range(1000,5000)] 
    public int cc = 1500;
    [Tooltip("這是汽車的重量 範圍3 ~ 20 T"),Range(3,20)]
    public float weight = 3.5f;
    public string brand = "BMW";
    public bool skywindow = true;
    #endregion

    #region 主要類型
    //顏色
    public Color Color1;
    public Color ColorRed = Color.red;
    public Color ColorBlue = new Color(0, 0, 1);
    public Color ColorAlpha = new Color(0, 1, 0, 0.5f);
    //座標
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2custom = new Vector2(1, 2);
    public Vector3 v3custom = new Vector3(1, 2, 3);
    public Vector4 v4custom = new Vector4(1, 2, 3, 4);
    //按鍵
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    //物件
    public GameObject caroil;
    public GameObject carbox;
    //元件
    public Transform trans;
    public Camera cam;

    #endregion

    #region get set 程式
    private void Start()
    {
        print("hello world");

    }
    #endregion

}
