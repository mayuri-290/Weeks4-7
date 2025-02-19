using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hourhandRotation : MonoBehaviour
{
    public float speed=5f;
    public AudioSource chime;
    public AudioClip clip;

    public GameObject bird;

    public int chimeCount;

    // Start is called before the first frame update
    void Start()
    {
        bird.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z -= speed * Time.deltaTime; 
        transform.eulerAngles = rot;

        int clockSpeed = (int)rot.z;
        if (Mathf.Abs(clockSpeed % 30) == 0)
        {
            if(chime.isPlaying==false)
            {
                chime.PlayOneShot(clip);
                bird.SetActive(true);
            }
        }
        else
        {
            bird.SetActive(false);
        }

        if (chimeCount == 0) chimeCount = 12;

        for(int i=0; i< chimeCount;i++)
        {
           //chime.isPlaying==true;
        }

    }
}
