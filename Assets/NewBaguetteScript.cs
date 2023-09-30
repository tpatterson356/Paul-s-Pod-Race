using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBaguetteScript : MonoBehaviour
{
    public GameObject baguette;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }    
        else
        {
            spawnBaguette();
            timer = 0;
        }
        
    }
    void spawnBaguette()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(baguette, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
