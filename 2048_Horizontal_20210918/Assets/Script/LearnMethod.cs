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
        Drive(200);
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
    public void Drive(int speed) {
        print("�ɳt��:" + speed);
        print("����");
    }
}
