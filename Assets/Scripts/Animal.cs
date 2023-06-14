using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public float speed = 5.0f;
    
    void Update()
    {
        Move(); // ABSTRACTION
    }

    public virtual void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


}

