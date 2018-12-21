using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateParticle : MonoBehaviour
{
    public Transform parent;

    private ParticleSystem ps;

    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        ps.transform.rotation = parent.transform.rotation;

        //GameObject particlesystem = (GameObject)Instantiate(pSystem); //Instantiate Particle System on Left Click
        //particlesystem.transform.rotation = rotatorObject.transform.rotation;//Set it's rotation to be the same as the rotatorObject.
        //particlesystem.transform.localEulerAngles = new Vector3(45,0,0);  //Manually set the rotation, if desired.
    }

    void Update()
    {
        Debug.Log("Parent local Rotation: " + parent.localRotation + "PS local Rotation: " + ps.transform.localRotation);
        Debug.Log("Parent Rotation: " + parent.rotation + "PS Rotation: " + ps.transform.rotation);
        ps.transform.rotation = parent.rotation;
        //transform.localRotation = parent.localRotation;

    }
}
