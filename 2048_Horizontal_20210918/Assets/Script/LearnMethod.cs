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
        Drive(200,"轟轟轟");
        Drive(200);
        Drive(300, effect: "石頭");

        int t = Ten();

        print("變數的數字為:" + t);
        print("不使用變數來印出方法的值:" + Ten());
        int damage = Damage(90, 30);
        print("90攻擊力減去30防禦等於" + damage);
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
    public void Drive(int speed,string sound = "咻咻咻",string effect = "灰塵") {
        print("時速為:" + speed);
        print("音效:" + sound);
        print("特效:" + effect);
    }

    public int Ten() {
        return 10;
    }

    public int Damage(int attack,int defense) {

        return attack - defense;
    }
}
