using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerzas_Aceleration : MonoBehaviour
{
    Rigidbody rb;
    

    [SerializeField]
    float speedFuerza = 50f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        //rb.AddForce(new Vector3(0f, 0f, 0f), ForceMode.Acceleration);
        //rb.AddForce(Vector3.right * 20f, ForceMode.Acceleration);  //globales
        rb.AddForce(transform.right * speedFuerza, ForceMode.Acceleration);  //locales
    }
}
