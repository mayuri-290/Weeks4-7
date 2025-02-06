using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //we need this using claim to ensure we use text.

public class Text : MonoBehaviour
{
    public TextMeshProUGUI score;
    int mouseDown = 0;

    // Start is called before the first frame update
    void Start()
    {
        score.text = mouseDown.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mouseDown += 1;
            score.text = mouseDown.ToString();
        }
    }
}
