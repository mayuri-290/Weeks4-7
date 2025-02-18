using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnGarbages : MonoBehaviour
{
    public GameObject SpaceGarbagePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            Vector2 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            GameObject newGarbages = Instantiate(SpaceGarbagePrefab, mouse, Quaternion.identity);

            Destroy(newGarbages, 5);

        }
    }
}
