using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;


public class planetRotation : MonoBehaviour
{
    public Slider planetRot;
    public float PlanetRotScale;

    void Update()
    {

        PlanetRotScale = planetRot.value * 1f;
        this.transform.rotation = Quaternion.Euler(0, 0, PlanetRotScale);

        }

}

