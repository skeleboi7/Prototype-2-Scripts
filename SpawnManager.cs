using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    public GameObject[ ] animalPrefabs; 
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    // Update is called once per frame
    void Update(){
}

    void SpawnRandomAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnpos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}