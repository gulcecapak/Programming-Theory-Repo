using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -25;
    private float spawnLimitXRight= 8;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();  //ABSTRACTION
        Invoke("SpawnBall", startDelay);
    }

    void SpawnBall()
    {   int ballIndex = Random.Range(0, ballPrefabs.Length);

        Instantiate(ballPrefabs[ballIndex], GenerateSpawnPosition(), ballPrefabs[ballIndex].transform.rotation);

        float spawnInterval = 4.0f;

        Invoke("SpawnBall", spawnInterval);
    }

    private Vector3 GenerateSpawnPosition()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        return spawnPos;
    }


}
