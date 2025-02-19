using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletSizeControl : MonoBehaviour
{
    public TankShooting tankShooting;
    public Slider bulletSizeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (bulletSizeSlider == null)
        {
            enabled = false;
        }
        if (tankShooting == null)
        {
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

