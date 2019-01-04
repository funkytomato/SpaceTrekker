using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Just for debugging, adds some velocity during OnEnable")]

    //To start we have a Vector3 for an initial velocity.  Like the tooltip says, this is just for the example / debugging.  Our OnEnable method will set the initial velocity to this value so the ball starts moving.
    private Vector3 initialVelocity;

    [SerializeField]
    //The minVelocity field is used to control how slow the ball can go.  Every bounce will be at this velocity (or higher).
    private float minVelocity = 10f;

    private Vector3 lastFrameVelocity;
    private Rigidbody rb;

    //Here, we’re caching the rigidbody reference and setting that initial velocity.
    private void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = initialVelocity;
    }

    //This one’s important.  Because we’re going to override the collision behavior, we need to keep track of the objects velocity each frame.  When the collisions happen, this velocity is going to change, but for our calculations, we want the velocity before the collision.  Saving it off here in Update is an easy solution.
    private void Update()
    {
        lastFrameVelocity = rb.velocity;
    }

    //This is where we do the work..even though it’s not much work.  Calculating direction is done using Vector3.Reflect.  We pass in the last frame velocity(that we cached in Update), along with the collision’s normal.Then we multiply the result by the current velocity OR the minVelocity, whichever is greater.
    private void OnCollisionEnter(Collision collision)
    {
        Bounce(collision.contacts[0].normal);
    }

    private void Bounce(Vector3 collisionNormal)
    {
        var speed = lastFrameVelocity.magnitude;
        var direction = Vector3.Reflect(lastFrameVelocity.normalized, collisionNormal);
        Debug.Log("Out Direction: " + direction);
        rb.velocity = direction * Mathf.Max(speed, minVelocity);
    }
}
