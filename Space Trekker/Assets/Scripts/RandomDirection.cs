using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDirection : MonoBehaviour
{
    //private Transform transform;
    public GameObject Boundary;
    public float Speed;
    private Vector3 destination;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //transform.rotation = Quaternion.LookRotation(RandomInCone(360));
        //rb.rotation = Quaternion.LookRotation(RandomInCone(20));

        Debug.Log("RandomDirection Start- rigidbody rotation : " + rb.rotation);
        destination = RandomPointInBox(Vector3.zero, Boundary.transform.localScale);
        rb.rotation = Quaternion.LookRotation(destination, Vector3.forward);
        //rb.rotation = Quaternion.LookRotation(position);
        Debug.Log("RandomDirection Start position: " + destination + "rotation : " + rb.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = Speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, destination, step);
    }

    private void FixedUpdate()
    {

    }

    public static Vector3 RandomInCone(float radius)
    {
        //(sqrt(1 - z^2) * cosϕ, sqrt(1 - z^2) * sinϕ, z)
        float radradius = radius * Mathf.PI / 360;
        float z = Random.Range(Mathf.Cos(radradius), 1);
        float t = Random.Range(0, Mathf.PI * 2);
        return new Vector3(Mathf.Sqrt(1 - z * z) * Mathf.Cos(t), Mathf.Sqrt(1 - z * z) * Mathf.Sin(t), z);
    }


    private static Vector3 RandomPointInBox(Vector3 center, Vector3 size)
    {

        return center + new Vector3(
           (Random.value - 0.5f) * size.x,
           (Random.value - 0.5f) * size.y,
           (Random.value - 0.5f) * size.z
        );
    }
}
