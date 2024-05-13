using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 30f;
    private float lowerBounds = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if object is not visible on screen destroy object
        if( transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        // if object passes player destroy the game object
        else if ( transform.position.z < lowerBounds )
        { 
            Destroy(gameObject); 
        }

    }
}
