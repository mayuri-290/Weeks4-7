using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

//I write this script for the UI slider. 
//The UI slider will control the planet, by moving the slider, the planet will rotate in certain angles.

public class planetRotation : MonoBehaviour
{
    public Slider planetRot;//set a public value of slider that controls planet rotation.
    public float PlanetRotScale;//This value will store the rotation value based on the slider input.

    void Update()
    {

        PlanetRotScale = planetRot.value * 1f;
        //get the slider value from UI and store it to control rotation.

        transform.rotation = Quaternion.Euler(0, 0, PlanetRotScale);
        //Apply the rotation to the planet object.
        // x = 0 and y = 0 is because this two value will not be used in rotation. 
        // z is needed. The action around the Z-axis, making the object rotate.
    }

}

