using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStartPosition : MonoBehaviour
{

    public GameObject prefab;
    public GameObject Boundary; 

    // Instantiate the Prefab somewhere between -10.0 and 10.0 on the x-z plane
    void Start()
    {

        Vector3 position = RandomPointInBox(Vector3.zero, Boundary.transform.localScale);
        Instantiate(prefab, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
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
