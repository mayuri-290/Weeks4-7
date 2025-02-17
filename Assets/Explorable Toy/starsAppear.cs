using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starsAppear : MonoBehaviour
{

    public GameObject StarsPrefab;

    public int starNumber = 8;
    public float StarAppearingTime = 1f;

    private bool StarsPrefabAppear = false;


    // Start is called before the first frame update
    void Start()
    {

        if (StarsPrefab == null)
        {
            StarsPrefabAppear = false;
        }
        else
        {
            StarsPrefabAppear = true;
        }

    }

     void Update()
    {
     
    }

    public void SpawnStars()
    {
        if (StarsPrefabAppear)
        {
            for (int i = 0; i < starNumber; i++)
            {
                Vector3 randomPosition = new Vector3(Random.Range(-10,10), Random.Range(0f, 5f), 0);
                GameObject star = Instantiate(StarsPrefab, randomPosition, Quaternion.identity);
                Destroy(star, StarAppearingTime);
            }
        }
    }
}

