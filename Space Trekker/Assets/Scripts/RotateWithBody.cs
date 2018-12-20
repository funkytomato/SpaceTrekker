using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithBody : MonoBehaviour
{
    public Transform body;
    public float RotateSpeed = 3.0F;

    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * 5.0f;
        foreach (Transform oChild in transform)
        {
            oChild.GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * 5.0f;
        }
    }
}
