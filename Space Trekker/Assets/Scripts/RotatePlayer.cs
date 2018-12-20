using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatePlayer : MonoBehaviour
{
    public float RotateSpeed = 3.0F;

    void Update()
    {
        if (transform != null)
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
        }
    }
}
