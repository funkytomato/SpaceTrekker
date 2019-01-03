using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public int Zoom;
    private Vector3 offset;         //Private variable to store the offset distance between the player and camera


    // Start is called before the first frame update
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position * Zoom;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if ( player != null)
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = player.transform.position + offset;
        }
        else
        {
            Debug.Log("Player gameobject is nil.  Probably destroyed.");
        }

    }
}