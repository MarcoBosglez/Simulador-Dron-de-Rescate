using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer: MonoBehaviour
{
    
    public float speed = 50f;

    void Update()
    {
        //AdelanteAtras

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, 2.5f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -2.5f * Time.deltaTime);
        }

        //ArribaAbajo
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(0, 2.5f * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(0, -2.5f * Time.deltaTime, 0);
        }

        //Rotacion
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, speed * Time.deltaTime);

            }
        }
}
