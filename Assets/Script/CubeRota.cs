using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRota : MonoBehaviour
{

    public Vector3 worldPosition;
    void OnMouseDrag()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z =Camera.main.nearClipPlane + 2;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;
    }

    void Update()
    {
        
    }
}
