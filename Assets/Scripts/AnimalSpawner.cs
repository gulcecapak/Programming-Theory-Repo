using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
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
            Vector3 spawnPos = new Vector3(-55, 0, 0);
            Instantiate(GameManager.instance.currentAnimalCharacter.animalPrefab, spawnPos, GameManager.instance.currentAnimalCharacter.animalPrefab.transform.rotation);

        }
    }

}
