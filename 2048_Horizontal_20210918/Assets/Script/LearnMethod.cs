using UnityEngine;
/// <summary>
/// Summary 摘要
/// 顯示在VS編譯器上
/// </summary>
public class LearnMethod : MonoBehaviour
{


    public void Test() {
        print("我是執行方法");
    }

    public void Start() {
        Test();
        Test();
        Drive90();
        Drive150();
        //   引數
        Drive(200);
    }

    //企劃需求
    //汽車時速為90
    //汽車時速為150

    public void Drive90() {
        print("時速為:" + 90);
        print("音效");
    }
    public void Drive150() {
        print("時速為:" + 150);
        print("音效");
    }
    //參數 參數類型
    public void Drive(int speed) {
        print("時速為:" + speed);
        print("音效");
    }
}
