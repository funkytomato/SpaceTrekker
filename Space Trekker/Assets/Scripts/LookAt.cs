using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Creates a rotation with the specified forward and upwards directions.

Z axis will be aligned with forward, X axis aligned with cross product between forward and upwards, and Y axis aligned with cross product between Z and X.

Returns identity if forward or upwards magnitude is zero. 
Returns identity if forward and upwards are colinear.
 * 
 *  You can also use transform.LookAt
 */
public class LookAt : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
}
