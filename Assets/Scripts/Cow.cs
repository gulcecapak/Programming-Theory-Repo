using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Cow : Animal //INHERITANCE
{

    public override void Move() //POLYMORPHISM
    {
       
        transform.Translate(Vector3.forward * speed * (0.5f) * Time.deltaTime);

    }
    private void Update()
    {
        Move();
       
    }

}
