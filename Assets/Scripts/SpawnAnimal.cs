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

            Instantiate(animalPrefabs[1], transform.position, animalPrefabs[1].transform.rotation);
        }
    }
}
