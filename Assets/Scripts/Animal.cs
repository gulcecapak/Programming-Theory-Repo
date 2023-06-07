using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed = 20.0f;
    

    // Update is called once per frame
    void Update()
    {
        Move(); // ABSTRACTION
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

   
}

