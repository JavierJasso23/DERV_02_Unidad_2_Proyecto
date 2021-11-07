using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFisicas : MonoBehaviour
{
    public float desplazamiento = 10;
    Rigidbody rb;

    // Start is called before the first frame update


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //Debug.Log("Arriba");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("Izquierda");
            rb.MovePosition(rb.position + transform.right * -1f * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //Debug.Log("Atras");
            rb.MovePosition(rb.position + transform.forward * -1f * desplazamiento * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Arriba");
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime);
        }



    }
}
