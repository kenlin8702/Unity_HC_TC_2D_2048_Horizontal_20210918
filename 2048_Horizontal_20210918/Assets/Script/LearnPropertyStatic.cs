using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnPropertyStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("隨機數字(0~1)" + Random.value);
        print("攝影機數量" + Camera.allCamerasCount);

        Cursor.visible = false;
        print(Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
