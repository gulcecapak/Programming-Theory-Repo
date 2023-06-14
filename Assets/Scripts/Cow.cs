using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Cow : Animal //INHERITANCE
{
    [SerializeField] private float speed;

    public override void Move() //POLYMORPHISM
    {
        speed = 2.0f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    private void Update()
    {
        Move();
       
    }

}
