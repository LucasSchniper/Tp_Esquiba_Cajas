using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCja : MonoBehaviour
{
    float[] posicionesX = { -2f, 0f, 2f };
    float spawnY;

    void Start()
    {
        spawnY = transform.position.y;
    }

    void Update() { }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.CompareTag("Piso"))
        {
            float randomX = posicionesX[Random.Range(0, posicionesX.Length)];
            transform.position = new Vector3(randomX, spawnY, transform.position.z);
        }
    }
}
