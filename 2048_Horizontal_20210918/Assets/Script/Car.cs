using System;
using UnityEngine;


//class���O�Ź�
public class Car : MonoBehaviour
{
    #region �|�j����
    [Header("�o�OCC��"),Range(1000,5000)] 
    public int cc = 1500;
    [Tooltip("�o�O�T�������q �d��3 ~ 20 T"),Range(3,20)]
    public float weight = 3.5f;
    public string brand = "BMW";
    public bool skywindow = true;
    #endregion

    #region �D�n����
    //�C��
    public Color Color1;
    public Color ColorRed = Color.red;
    public Color ColorBlue = new Color(0, 0, 1);
    public Color ColorAlpha = new Color(0, 1, 0, 0.5f);
    //�y��
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2custom = new Vector2(1, 2);
    public Vector3 v3custom = new Vector3(1, 2, 3);
    public Vector4 v4custom = new Vector4(1, 2, 3, 4);
    //����
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    //����
    public GameObject caroil;
    public GameObject carbox;
    //����
    public Transform trans;
    public Camera cam;

    #endregion

    #region get set �{��
    private void Start()
    {
        print("hello world");

    }
    #endregion

}
