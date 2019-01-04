using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("DestroyByContact Start");

        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Asteroid")
        {
            //Debug.Log("DestroyByContact collider: " + other.name + " is triggered!");
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {

            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            //gameController.GameOver();
        }

        Debug.Log("DestroyByContact OnTriggerEnter:- Destroyed " + other.gameObject);
        Destroy(other.gameObject);

        Debug.Log("DestroyByContact OnTriggerEnter:- " + gameObject);
        Destroy(gameObject);
    }
}
