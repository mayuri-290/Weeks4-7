using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExplodeTiming : MonoBehaviour
{
    public Slider sliderTimer;
    public float t = 2f;

    public TextMeshProUGUI timerText;
  

    // Start is called before the first frame update
    void Start()
    {
        sliderTimer.minValue = 0;
        sliderTimer.maxValue = 5;
        sliderTimer.value = t;

        UpdateTimerText();
    }

    // Update is called once per frame
    void Update()
    {
        sliderTimer.value -= Time.deltaTime*0.3f;

        sliderTimer.value = Mathf.Max(sliderTimer.value, 0);

        UpdateTimerText();

    }
    void UpdateTimerText()
    {
        if (timerText)
        {
            timerText.text = "Time: " + sliderTimer.value.ToString("0.00");
        }
    }

}
