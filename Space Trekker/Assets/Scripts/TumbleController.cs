using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleController : MonoBehaviour
{

    public float Tumble;

    // Start is called before the first frame update
    void Start()
    {
        //This does not with the RandomDirection script!!!
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * Tumble;
        //transform.angularVelocity = Random.insideUnitSphere * Tumble;
    }
}
