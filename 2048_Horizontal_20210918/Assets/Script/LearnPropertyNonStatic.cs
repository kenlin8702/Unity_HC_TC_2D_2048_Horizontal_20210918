using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnPropertyNonStatic : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        print("��v���ƶq:" + Camera.allCamerasCount);

        print("��v���`��:" + cam.depth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
