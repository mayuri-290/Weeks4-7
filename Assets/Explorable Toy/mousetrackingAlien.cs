using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is for an alien character following the mouse when the right mouse button is clicked. 

public class mousetrackingAlien : MonoBehaviour
{
    private bool mouseFollow = false;//set a bool statement to check if the alien should follow the mouse.


    // Update is called once per frame
    void Update()
    {
        //I add a if statement and use getmousebuttonddown, since the mouse should be clicked only once.
        //Set the number to 1, because the "right" mouse button will be clicked. 

        if (Input.GetMouseButtonDown(1))
        {
            mouseFollow = true;

        }

        //Add one more if statement, when mouse floow is activated, update the alien position.
            if(mouseFollow)
            {
            Vector3 mousePosition = Input.mousePosition; //to get the current mouse position in screen coordinates.

            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
            //I use STWP to make sure the alien follow the mouse properly. 

            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
            //update the alien's position to follow the mouse. 
        }
    }

    }

