using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hourhandRotation : MonoBehaviour
{
    public float speed=5f;
    public AudioSource chime;
    public AudioClip clip;

    public GameObject bird;

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
      
    }
}
