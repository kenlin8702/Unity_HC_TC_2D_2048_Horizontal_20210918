using UnityEngine;
/// <summary>
/// Summary �K�n
/// ��ܦbVS�sĶ���W
/// </summary>
public class LearnMethod : MonoBehaviour
{


    public void Test() {
        print("�ڬO�����k");
    }

    public void Start() {
        Test();
        Test();
        Drive90();
        Drive150();
        //   �޼�
        Drive(200,"�F�F�F");
        Drive(200);
        Drive(300, effect: "���Y");

        int t = Ten();

        print("�ܼƪ��Ʀr��:" + t);
        print("���ϥ��ܼƨӦL�X��k����:" + Ten());
        int damage = Damage(90, 30);
        print("90�����O��h30���m����" + damage);
    }

    //�����ݨD
    //�T���ɳt��90
    //�T���ɳt��150

    public void Drive90() {
        print("�ɳt��:" + 90);
        print("����");
    }
    public void Drive150() {
        print("�ɳt��:" + 150);
        print("����");
    }
    //�Ѽ� �Ѽ�����
    public void Drive(int speed,string sound = "������",string effect = "�ǹ�") {
        print("�ɳt��:" + speed);
        print("����:" + sound);
        print("�S��:" + effect);
    }

    public int Ten() {
        return 10;
    }

    public int Damage(int attack,int defense) {

        return attack - defense;
    }
}
