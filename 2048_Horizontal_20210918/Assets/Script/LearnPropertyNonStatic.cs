using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnPropertyNonStatic : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        print("攝影機數量:" + Camera.allCamerasCount);

        print("攝影機深度:" + cam.depth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
