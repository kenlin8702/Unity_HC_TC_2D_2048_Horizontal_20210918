using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("�H���Ʀr(0~1)" + Random.value);
        print("��v���ƶq" + Camera.allCamerasCount);

        Cursor.visible = false;
        print(Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
