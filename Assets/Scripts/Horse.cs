using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Animal //INHERITANCE
{
    [SerializeField] private float speed;

    public override void Move() //POLYMORPHISM
    {
        speed = 7.0f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    
    private void Update()
    {
        Move();
    }
}
