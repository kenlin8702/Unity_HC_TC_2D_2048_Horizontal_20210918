using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnWhileFor : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        number = 1;
        while (number <= 5) {
            print("¼Æ¦r¡G" + number);
            number++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
