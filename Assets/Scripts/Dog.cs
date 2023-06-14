using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITANCE
{
    [SerializeField] private float speed;

    private void Update()
    {
        Move();
    }
}
