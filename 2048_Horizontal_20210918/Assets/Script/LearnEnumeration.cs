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
        print(state);//0會印出idle
    }
    private void Update() {
        print((int)state);
        switch (state) {
            case EnemyState.None:
                print("無");
                break;
            case EnemyState.Idle:
                print("等待中");
                break;
            case EnemyState.Walk:
                print("走路中");
                break;
            case EnemyState.Track:
                print("追蹤中");
                break;
            case EnemyState.Attack:
                print("攻擊中");
                break;
            case EnemyState.Died:
                print("死亡中");
                break;
        }
    }
}
