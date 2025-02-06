using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed=5;
    public GameObject carrot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position = pos;


        

    }
}
