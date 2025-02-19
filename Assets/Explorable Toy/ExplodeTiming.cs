using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//I create this script for manage countdown timer using UI slider and TextMeshPro function for the timing.

public class ExplodeTiming : MonoBehaviour
{
    public Slider sliderTimer;//Reference to the UI slider that visually represents the countdown.

    public float t = 2f;//Set the initial countdown time in seconds.

    public TextMeshProUGUI timerText;//isplays the remaining time in visual.


    // Start is called before the first frame update
    void Start()
    {
        //These codes will be called before the first frame updates.
        //set the slider's minimun and mix. values. I want to set timing to 5 minutes, so I set 5. 
        sliderTimer.minValue = 0;
        sliderTimer.maxValue = 5;
        sliderTimer.value = t;//Initialize the slider's value to the starting time

        UpdateTimerText();//Update the displayed timer text.
    }

    // Update is called once per frame
    void Update()
    {
        sliderTimer.value -= Time.deltaTime*0.3f;//Decrease the slider's value over time, simulating a countdown.

        sliderTimer.value = Mathf.Max(sliderTimer.value, 0);//Ensure the slider value does not go below zero.

        UpdateTimerText();//after setting the value and range of text, the timer text will be displayed. 

    }
    void UpdateTimerText()//Updates the displayed timer text to reflect the remaining time.
    {
        if (timerText)//write a condition to check if the timertext  exits before modifying it. 
        {
            timerText.text = "Time: " + sliderTimer.value.ToString("0.00");//also make sure the format of displaying the timing should be in two decimal places. 
            //Use ToString to set text formats. 
        }
    }

}
