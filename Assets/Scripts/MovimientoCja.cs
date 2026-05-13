using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCja : MonoBehaviour
{
    public float speed;
    public float speedIncrement = 1f;
    

    void Update()
    {
       transform.Translate(0,  -speed * Time.deltaTime,0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            speed += speedIncrement;
        }
    }
}
