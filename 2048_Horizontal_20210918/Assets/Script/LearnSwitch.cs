using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnSwitch : MonoBehaviour
{
    public string equipment;
    // Start is called before the first frame update
    void Start()
    {
        switch(equipment){
            case "�M�l":
                print("�A�{�b���۪��O�M�l");
                break;
            case "�e�l":
                print("�A�{�b���۪��O�e�l");
                break;
            default:
                print("�A�{�b���۪����O�Z��");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
