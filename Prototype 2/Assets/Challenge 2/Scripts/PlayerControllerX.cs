using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float currentIntervalFromNextDogSpawn;
    private float minIntervalFromNextDogSpawnInSec = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //Subtract the time passed from each frame from the current counter of time before next dog spawn
        if (currentIntervalFromNextDogSpawn > 0)
            currentIntervalFromNextDogSpawn -= Time.deltaTime;

        // On spacebar press, send dog if time passed before previous spawn dog
        if (Input.GetKeyDown(KeyCode.Space) && currentIntervalFromNextDogSpawn <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            currentIntervalFromNextDogSpawn = minIntervalFromNextDogSpawnInSec;
        }
    }
}
