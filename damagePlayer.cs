using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damagePlayer : MonoBehaviour
{

    public int playerHealth = 30;
    int damage = 10;

    bool cambioColorColision = false;
    public Material cosa;
    public GameObject CamaraDron;


    private void Start()
    {
        Debug.Log("Health:" + playerHealth);
    }

    private void OnCollisionEnter(Collision _collision)
    {

        if (_collision.gameObject.tag == "Collider")
        {
            playerHealth -= damage;
            Debug.Log("Enemy ataco al dron." + "Health:" + playerHealth);
            cambioColorColision = true;
        }



        if (_collision.gameObject.tag == "Meta")
        {
            Debug.Log("Llegaste a la meta!");

        }



        if (playerHealth <= 0)
        {
            Debug.Log("You died.");
            CamaraDron.transform.parent = this.transform.parent;
            Destroy(gameObject);


        }
    }

    private void OnCollisionExit(Collision collision)
    {
        cambioColorColision = false;
        
    }

    void Update()
    {
        if (cambioColorColision)
        {
            cosa.color = Color.red;
        }
        else
        {
            cosa.color = Color.cyan;
        }

    }
}
