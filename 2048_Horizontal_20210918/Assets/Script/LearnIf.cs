using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool Opendoor;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        if (true) {
            print("���L�� True");
        }
        if (false) {
            print("���L�� False");
        }

        if (Opendoor) {
            print("�}��");
        } else {
            print("����");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 60) {
            print("�ή�");
        }else if(score >= 40) {
            print("���ή�");
        } else {
            print("����");
        }
    }
}
