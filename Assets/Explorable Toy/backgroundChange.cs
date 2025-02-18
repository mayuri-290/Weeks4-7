using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class backgroundChange : MonoBehaviour
{
    public SpriteRenderer bg1;
    public SpriteRenderer bg2;
    public SpriteRenderer bg3;


    private int currentBackground=1;

    // Start is called before the first frame update

     void Start()
    {
       
    }

    public void ChangeBackground()
    {
        currentBackground = (currentBackground % 3) + 1;
        UpdateBackground();
    }

    void UpdateBackground()
    {
        bg1.gameObject.SetActive(currentBackground == 1);
        bg2.gameObject.SetActive(currentBackground == 2);
        bg3.gameObject.SetActive(currentBackground == 3);
    }

    



}
