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
        if(Input.GetMouseButtonDown(1))
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject newGarbages = Instantiate(SpaceGarbagePrefab, mouse, Quaternion.identity);

            newGarbages.transform.localScale = Vector3.one * Random.Range(0.5f, 1.5f);
            GarbageMove movementScript = newGarbages.GetComponent<GarbageMove>();

            if(movementScript !=null)
            {
                movementScript.speed = Random.Range(1, 5);
            }

            Destroy(newGarbages, 10);

        }
    }
}
