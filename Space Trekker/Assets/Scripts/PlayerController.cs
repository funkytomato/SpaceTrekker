using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject shot;

    //This is the Transform object for the Player
    public Transform shotSpawn;

    public float Thrust;
    public float Tilt;

    public float FireRate;

    private float nextFire;


    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + FireRate;

            //Create the bolt
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }



    }

    //Update for PhysicBodies
    private void FixedUpdate()
    {
        float applyThrust = Input.GetAxis("Vertical");

        applyThrust = applyThrust * Thrust;
        transform.position += transform.forward * Time.deltaTime * applyThrust;

        //rb2d.rotation = Quaternion.Euler(0.0f, 0.0f, rb2d.velocity.x * -tilt);
    }
}
