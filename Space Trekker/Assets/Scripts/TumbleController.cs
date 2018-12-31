using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleController : MonoBehaviour
{

    public float Tumble;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * Tumble;
    }
}
