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
            case "刀子":
                print("你現在拿著的是刀子");
                break;
            case "叉子":
                print("你現在拿著的是叉子");
                break;
            default:
                print("你現在拿著的不是武器");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
