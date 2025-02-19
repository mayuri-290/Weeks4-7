using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// This script is responsible for changing the background in the unity space scene.
//The idea is to have three different backgrounds and switch between them.

public class backgroundChange : MonoBehaviour
{
    //References to the three different backgrounds in the scene.
    public SpriteRenderer bg1;//first background
    public SpriteRenderer bg2;//second background
    public SpriteRenderer bg3;//third background

    //This integer keeps track of which background is currently active.
    private int currentBackground=1;//starts with background 1, set it active. 

    // Start is called before the first frame update

     void Start()
    {
       //nothing needed in game starts. 
    }

    //The public function here will be used or seen in the unity when we change background by clicking the button. 
    public void ChangeBackground()
    {
        //I use % to make the background cycles between bg1-bg3.
        //If the current background is 1, it changes to 2.
        //If the current background is 2, it changes to 3.
        //If the current background is 3, it loops back to 1.
        currentBackground = (currentBackground % 3) + 1;
        UpdateBackground();//Actives the function to update the background change.
    }

    //this code make sure the right background is "showing" in the screen by using setActive.
    void UpdateBackground()
    {
        //If currentBackground is 1, only bg1 is active, others are disabled
        bg1.gameObject.SetActive(currentBackground == 1);
        bg2.gameObject.SetActive(currentBackground == 2);
        bg3.gameObject.SetActive(currentBackground == 3);
    }

    



}
