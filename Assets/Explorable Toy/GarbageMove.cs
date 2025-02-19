using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script moves the space garbage left and right across the screen.
//When the object reaches the edge, it bounces back in the opposite direction.
public class GarbageMove : MonoBehaviour
{
    public float speed = 0.5f;//set the speed at which the object moves.

    void Start()
    {
        Destroy(gameObject, 10);//This make sure the object gets removed after 10 seconds so it doesn’t stay forever

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;//get the object’s current position.
        pos.x += speed * Time.deltaTime;//move the object a little bit to the right (or left if speed is negative).

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);
        //This convert the object’s position from the game world to the screen coordinates.

        //set a if statement shows that the object moves off the left edge of the screen
        if (screenPos.x <0)
        {
            //make the object back to the left edge.
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;//make the object move in the opposite direction using negative. 


        }

        //same as above, but on a different side. 
        if (screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;
        }

        //apply the new position to the object.
        transform.position = pos;
    }
}
