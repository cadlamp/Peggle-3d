using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallWithCamera : MonoBehaviour
{
    public Transform ballTransform;
    public Transform cameraTransform;

    // Update is called once per frame
    void Update()
    {
        cameraTransform.position = ballTransform.position;
    }
}
