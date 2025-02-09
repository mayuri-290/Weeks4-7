using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetRotation : MonoBehaviour
{
    public float speed = 5f; //set rotation speed
    public bool mouseDragging = false;//set a boolean expression for mouse click
    private Vector2 lastMousePosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetMouseButtonDown(0))
        {
            mouseDragging = true;
            lastMousePosition = Input.mousePosition;
        }
    else
            if(Input.GetMouseButtonUp(0))
        {
            mouseDragging = false;
        }

        if (mouseDragging)
        {
            Vector2 currentMousePos = Input.mousePosition;
           
            float moveX = currentMousePos.x - lastMousePosition.x;
            transform.Rotate(0, 0, -moveX * 0.5f);
            lastMousePosition = currentMousePos;
        }

    }
}
