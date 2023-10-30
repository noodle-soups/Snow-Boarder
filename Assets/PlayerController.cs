using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float torqueAmount = 1f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float speedBase = 12f;
    [SerializeField] float speedBoost = 20f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = speedBoost;
        }
        else 
        {
            surfaceEffector2D.speed = speedBase;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torqueAmount);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torqueAmount);
        }
    }

}
