using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetrackingAlien : MonoBehaviour
{
    public Vector3 mousePos;

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(1))
        {
            if(Input.GetMouseButton(1))
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.z = 0;
                transform.position = mousePos;
            }
        }
    }
}
