using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float startDelay = 1.0f;

    private void Start()
    {
        Invoke("AnimalSpawn", startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        AnimalSpawn();
    }

    public void AnimalSpawn()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Vector3 spawnPos = new Vector3(-55, 0, 0);


            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
