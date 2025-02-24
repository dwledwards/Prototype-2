using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variable to store horizontal input
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If player moves beyond the X range reset the player position to the X range value
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Get the horizontal input to move player left and right
        horizontalInput = Input.GetAxis("Horizontal");    
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);  

        // Get get key which is required to launch the projectile
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate and launch projectile
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
