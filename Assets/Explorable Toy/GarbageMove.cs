using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageMove : MonoBehaviour
{
    public float speed = 0.5f;

    void Start()
    {
        Destroy(gameObject, 10);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if(screenPos.x <0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;

        }

        if(screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;
        }

        transform.position = pos;
    }
}
