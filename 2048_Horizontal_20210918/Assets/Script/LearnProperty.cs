using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    public int passwordfield = 123456;

    //�ݩʤ��|��ܨ쭱�O�W
    public int passwordProperty { get; set; }

    public int mypasswordProperty { get => 999;  }

    public string nameCharacter {
        get {
            print("���r��b nameChacater �̭��I");
            return "KEN";
        }
    }
    public float attack {

        set {
            print("�����O�G" + value);
        }
    }
    public void Start() {
        passwordProperty = 777;
        print("�ݩʱK�X�G" + passwordProperty);

        //mypasswordProperty = 999 ; //�S��set =��Ū�ݩʤ���ק�
        print("�ݩʱK�X�G" + mypasswordProperty);

        print("�H���W�١G" + nameCharacter);

        //print(attack); �S��get = �߼g�ݩʤ���Ū�� �@��ܤ֥Ψ�
        attack = 99.9f;

    }
}
