using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{

    // Smoothly tilts a transform towards a target rotation.
    public float TiltAngle;
    private float smooth = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var tiltAroundZ = Input.GetAxis("Horizontal") * TiltAngle;
        //var tiltAroundX = Input.GetAxis("Vertical") * TiltAngle;
        var target = Quaternion.Euler(0, 0, tiltAroundZ);

        // Damper towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

    }
}
