using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    public int passwordfield = 123456;

    //屬性不會顯示到面板上
    public int passwordProperty { get; set; }

    public int mypasswordProperty { get => 999;  }

    public string nameCharacter {
        get {
            print("此字串在 nameChacater 裡面！");
            return "KEN";
        }
    }
    public float attack {

        set {
            print("攻擊力：" + value);
        }
    }
    public void Start() {
        passwordProperty = 777;
        print("屬性密碼：" + passwordProperty);

        //mypasswordProperty = 999 ; //沒有set =唯讀屬性不能修改
        print("屬性密碼：" + mypasswordProperty);

        print("人物名稱：" + nameCharacter);

        //print(attack); 沒有get = 唯寫屬性不能讀取 一般很少用到
        attack = 99.9f;

    }
}
