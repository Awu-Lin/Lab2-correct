using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetup : MonoBehaviour
{
    public float positionX = -3.5f;
    public float positionY = 0.4f;
    public float positionZ = -10.1f;

    void Start()
    {
        transform.position = new Vector3(positionX, positionY, positionZ);
    }
}


