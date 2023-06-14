using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        Move(); // ABSTRACTION
    }

    public virtual void Move()
    {
        speed = 5.0f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


}

