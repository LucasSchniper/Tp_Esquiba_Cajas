using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    public Transform PlayerTR;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(new Vector3(2f, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(new Vector3(-2f, 0, 0));
        }
    }       

}
