using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDirection : MonoBehaviour
{

    //private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 euler = transform.eulerAngles;
        euler.z = Random.Range(0f, 360f);
        transform.eulerAngles = euler;
        Debug.Log("RandomDirection Start:" + transform.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
