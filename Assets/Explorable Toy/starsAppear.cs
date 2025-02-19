using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//I write this script for managing the appearance of stars in the scene, when clicking the button. 

public class starsAppear : MonoBehaviour
{

    public GameObject StarsPrefab;//set the star prefab.

    public int starNumber = 8;//Number of stars to spawn each time the function is called.

    public float StarAppearingTime = 1f;//Duration before each spawned star disappears.
    //I simply set the duration time to 1 sec, to prevent too many objects cluttering in the scene, since there will be other effects. 


    private bool StarsPrefabAppear = false;//I set a bool statement to check if the star prefab is assigned.


    // Start is called before the first frame update
    void Start()
    {
        //check if the star prefab is set up correctly.
        //If there is no prefab assigned, then set the condition to false so the system don't spawn anything.
        //else set it to true, means the stars can be created when clicking the button. 
        if (StarsPrefab == null)
        {
            StarsPrefabAppear = false;
        }
        else
        {
            StarsPrefabAppear = true;
        }

    }

     void Update()
    {
     
    }

    public void SpawnStars()//set this function to spawn stars at random positions within a defined range. 

    {
        if (StarsPrefabAppear)
        {
            for (int i = 0; i < starNumber; i++)
             
            {
                Vector3 randomPosition = new Vector3(Random.Range(-10,10), Random.Range(0f, 5f), 0);
                //x is set between -10 and 10, it is a good range for a spread-out effect after testing the scene size.
                //y is set between 0 and 5, keeping stars within the visible upper screen range.
                //z remains 0, no rotation is needed.

                GameObject star = Instantiate(StarsPrefab, randomPosition, Quaternion.identity);
                //Instantiate the star prefab at a random position without rotation.
                Destroy(star, StarAppearingTime);
                //make sure the stars don't stay forever in the scene. 
                //They will disappear after  1 sec, as set value above, to keep the screen clean. 
            }
        }
    }
}

