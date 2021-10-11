using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 0.1f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Bergerak saat tahan klik kiri mouse
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }
}
