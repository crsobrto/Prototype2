using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20.0f;
    private float spawnPosZ = 15.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalFromAbove", startDelay, spawnInterval); // Spawn animals on a timer
        InvokeRepeating("SpawnRandomAnimalFromLeft", startDelay, spawnInterval); // Spawn animals on a timer
        InvokeRepeating("SpawnRandomAnimalFromRight", startDelay, spawnInterval); // Spawn animals on a timer
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalFromAbove()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // 0 inclusive, animalPrefabs.Length exclusive
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // Create a new spawn position for the animals with a random x value

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); // Spawn a new animal from the array
    }

    void SpawnRandomAnimalFromLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(3, spawnPosZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.right));
    }

    void SpawnRandomAnimalFromRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(3, spawnPosZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.left));
    }
}
