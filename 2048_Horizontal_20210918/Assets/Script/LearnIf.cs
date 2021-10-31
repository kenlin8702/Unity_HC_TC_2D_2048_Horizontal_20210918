using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool Opendoor;
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
        
    }
}
