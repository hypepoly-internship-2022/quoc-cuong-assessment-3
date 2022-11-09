using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRota : MonoBehaviour
{
    float rotationSpeed = 34f;

    void OnMouseDrag()
    {
        float xAxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

        transform.Rotate(Vector3.forward, xAxisRotation);
    }
}
