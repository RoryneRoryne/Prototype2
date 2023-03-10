using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[]animalPrefabs;
    public GameObject[]animalPrefabsRight;
    public GameObject[]animalPrefabsLeft;
    float spawnRangeX = 20f;
    float spawnRangeZ = 30f;
    float spawnDelay = 2f;
    float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //untuk otomatis memanggil dan mengulang suatu method
        //to automaticly call and repeat certain method
        InvokeRepeating("SpawnRandomAnimal", spawnDelay,spawnInterval);
        InvokeRepeating("SpawnFromRight", spawnDelay,spawnInterval);
        InvokeRepeating("SpawnFromLeft", spawnDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        //variabel untuk random animal index
        //variable for random animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //variabel untuk tempat spawn object dan membuat object muncul secara random pada suatu titik
        //variable to make an object spawn and make it randomly spawn at certain position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0, spawnRangeZ);
        //untuk memunculkan copy dari animal pada posisi random
        //to spawn and copy an object at random position.
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        
    }

    void SpawnFromRight()
    {
        //variabel untuk random animal index
        //variable for random animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //variabel untuk tempat spawn object dan membuat object muncul secara random pada suatu titik
        //variable to make an object spawn and make it randomly spawn at certain position
        Vector3 spawnPosRight = new Vector3(spawnRangeX, 0, Random.Range(spawnRangeZ, -10));
        //untuk memunculkan copy dari animal pada posisi random
        //to spawn and copy an object at random position.
        Instantiate(animalPrefabsRight[animalIndex], spawnPosRight, animalPrefabsRight[animalIndex].transform.rotation);
    }
    void SpawnFromLeft()
    {
        //variabel untuk random animal index
        //variable for random animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //variabel untuk tempat spawn object dan membuat object muncul secara random pada suatu titik
        //variable to make an object spawn and make it randomly spawn at certain position
        Vector3 spawnPosLeft = new Vector3(-spawnRangeX, 0, Random.Range(spawnRangeZ, -10));
        //untuk memunculkan copy dari animal pada posisi random
        //to spawn and copy an object at random position.
        Instantiate(animalPrefabsLeft[animalIndex], spawnPosLeft, animalPrefabsLeft[animalIndex].transform.rotation);
    }
}
