using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float xAxisValue;

    // Update is called once per frame
    void Update()
    {
        // Get input axes
        xAxisValue = Input.GetAxis("Horizontal");

        // Move the camera
        transform.Translate(new Vector3(xAxisValue * 0.010f, 0.0f, 0.0f));
    }
}
