using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script spawns space garbage objects when the right mouse button is clicked.
//Each spawned garbage object will have a random size and movement speed.

public class spawnGarbages : MonoBehaviour
{
    public GameObject SpaceGarbagePrefab;//initiate the garbage prefab.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))//Check if the right mouse button was clicked. 1 for right click.

        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Convert the mouse position from screen coordinates to world coordinates

            GameObject newGarbages = Instantiate(SpaceGarbagePrefab, mouse, Quaternion.identity);
            //Create a new garbage object at the mouse position with no rotation.


            newGarbages.transform.localScale = Vector3.one * Random.Range(0.5f, 1.5f);
            //Assign a random size to the garbage object, between 0.5 and 1.5 is a good range after tesing, the garbage should also not be too big. 
            
            GarbageMove movementScript = newGarbages.GetComponent<GarbageMove>();
            //Get the GarbageMove script component from previous created garbage movement.
            //This script is responsible for moving the garbage object, so we need access to it.

            //If the garbage object contains the GarbageMove script, set its speed to a random value.
            //each garbage object should also moves at a different speed, making the movement more natural.
            //the speed is chosen randomly between 1 and 5, without being too slow or too fast.
            if (movementScript !=null)
            {
                movementScript.speed = Random.Range(1, 5);
            }

            Destroy(newGarbages, 10);
            //Ensure the garbage object is destroyed after 10 seconds to keep the scene clean.


        }
    }
}
