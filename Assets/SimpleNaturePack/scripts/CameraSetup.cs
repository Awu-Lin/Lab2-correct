using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetup : MonoBehaviour
{   //Parameters for setting the initial camera position
    public float positionX = -3.5f;
    public float positionY = 0.4f;
    public float positionZ = -10.1f;

    void Start()
    {
        //Adjust the camera position to the set position
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
}


