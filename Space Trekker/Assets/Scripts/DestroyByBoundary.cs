using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("DestroyByBoundary OnTriggerExit Destroyed " + other.gameObject + other.gameObject.transform.position);
        Destroy(other.gameObject);
    }
}
