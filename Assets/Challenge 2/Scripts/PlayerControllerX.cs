using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitTime = 0.0f;
    private float timer = 0.0f;
    private float interval = 2.0f;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer >= waitTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            waitTime = timer + interval;
        }
    }
}
