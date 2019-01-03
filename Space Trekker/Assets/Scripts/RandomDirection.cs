﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDirection : MonoBehaviour
{
    //private Transform transform;

    public float Speed;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Vector3 euler = transform.eulerAngles;
        //euler.z = Random.Range(0f, 360f);
        //transform.eulerAngles = euler;
        //Debug.Log("RandomDirection Start:" + transform.eulerAngles);


        //transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        //transform.forward = Vector3.forward * Speed;

        //transform.forward = RandomInCone(360) * 1.0f;
        transform.rotation = Quaternion.LookRotation(RandomInCone(360));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector3.forward * Speed;
    }

    public static Vector3 RandomInCone(float radius)
    {
        //(sqrt(1 - z^2) * cosϕ, sqrt(1 - z^2) * sinϕ, z)
        float radradius = radius * Mathf.PI / 360;
        float z = Random.Range(Mathf.Cos(radradius), 1);
        float t = Random.Range(0, Mathf.PI * 2);
        return new Vector3(Mathf.Sqrt(1 - z * z) * Mathf.Cos(t), Mathf.Sqrt(1 - z * z) * Mathf.Sin(t), z);
    }
}
