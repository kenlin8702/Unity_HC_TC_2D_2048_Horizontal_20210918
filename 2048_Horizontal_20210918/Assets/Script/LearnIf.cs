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
            print("布林值 True");
        }
        if (false) {
            print("布林值 False");
        }

        if (Opendoor) {
            print("開門");
        } else {
            print("關門");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 60) {
            print("及格");
        }else if(score >= 40) {
            print("不及格");
        } else {
            print("死當");
        }
    }
}
