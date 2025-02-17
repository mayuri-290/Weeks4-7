using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplodeTiming : MonoBehaviour
{
    public Slider sliderTimer;
    public float t = 2f;

    // Start is called before the first frame update
    void Start()
    {
        sliderTimer.minValue = 0;
        sliderTimer.maxValue = 5;
        sliderTimer.value = t;
    }

    // Update is called once per frame
    void Update()
    {
        sliderTimer.value -= Time.deltaTime*0.3f;
    }
}
