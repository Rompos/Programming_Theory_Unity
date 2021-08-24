using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastCar : Vehicles // INHERITANCE
{
    private void Start()
    {
        Speed = 10;
        RotateSpeed = 220;
    }
    protected override void Update() // POLYMORPHISM
    {
        base.Update();
    }

    protected override void PlayHornSound() // POLYMORPHISM
    {
        base.PlayHornSound();
        Debug.Log("Who just bipped: " + gameObject.name);
    }
}
