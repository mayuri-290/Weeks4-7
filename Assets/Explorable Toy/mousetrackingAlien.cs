using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetrackingAlien : MonoBehaviour
{
    private bool mouseFollow = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mouseFollow = true;

        }

            if(mouseFollow)
            {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }
    }

    }

