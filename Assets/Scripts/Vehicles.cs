using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicles : MonoBehaviour
{
    private float horMove, verMove;
    private float speed;
    private float rotateSpeed;
    public float Speed
    {
        get
        {
            return speed;
        }
        protected set
        {
            speed = value;
        }
    } // ENCAPSULATION

    public float RotateSpeed
    {
        get
        {
            return rotateSpeed;
        }
        protected set
        {
            rotateSpeed = value;
        }
    } // ENCAPSULATION
    [SerializeField] protected AudioSource hornSFX; // ENCAPSULATION

    protected virtual void Update() // POLYMORPHISM
    {
        horMove = Input.GetAxis("Horizontal");
        verMove = Input.GetAxis("Vertical");
        Driving();
        PlayHornSound();
    }

    private void Driving()
    {
        transform.Translate(Vector3.forward * verMove * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * horMove * rotateSpeed * Time.deltaTime);
    }

    protected virtual void PlayHornSound() // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            hornSFX.Play();
        }
    }
}
