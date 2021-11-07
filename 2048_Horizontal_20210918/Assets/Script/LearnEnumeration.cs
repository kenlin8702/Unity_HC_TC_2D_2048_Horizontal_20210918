using System;
using UnityEngine;

public class LearnEnumeration : MonoBehaviour
{

    [Flags]
    public enum EnemyState {
        None = 0b_0000_0000,
        Idle = 0b_0000_0001,
        Walk = 0b_0000_0010,
        Track = 0b_0000_0100,
        Attack = 0b_0000_1000,
        Died = 0b_0001_0000,
    }
    public EnemyState state;

    private void Start() {

        state = (EnemyState)6;
        print(state);//0�|�L�Xidle
    }
    private void Update() {
        print((int)state);
        switch (state) {
            case EnemyState.None:
                print("�L");
                break;
            case EnemyState.Idle:
                print("���ݤ�");
                break;
            case EnemyState.Walk:
                print("������");
                break;
            case EnemyState.Track:
                print("�l�ܤ�");
                break;
            case EnemyState.Attack:
                print("������");
                break;
            case EnemyState.Died:
                print("���`��");
                break;
        }
    }
}
