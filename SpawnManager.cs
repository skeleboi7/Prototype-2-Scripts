using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float spawnRangeZ = 7.5f;
    private float spawnOffsetZ = 7.5f;
    private float spawnPosX = 20;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int randomDirection = Random.Range(1, 4);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        if (randomDirection == 1 )
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }

        else if(randomDirection == 2 )
        {
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ) + spawnOffsetZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0.0f, 90.0f, 0.0f));
        }

        else if(randomDirection == 3 )
        {
            Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ) + spawnOffsetZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation * Quaternion.Euler(0.0f, -90.0f, 0.0f));
        }

    }
}