using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;
    public AudioSource audioSouces;
    public AudioClip clip;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            //script.enabled = true;
            go.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Space)) //if(audioSource.GetKey(KeyCode.Space)--hold the key and kept playing.
        {
            //audioSouces.Play();
            audioSouces.PlayOneShot(clip);
        }
    }
}
