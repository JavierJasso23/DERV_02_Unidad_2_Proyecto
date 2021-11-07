using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 InputRot;
    Rigidbody rb;

    [SerializeField]
    float sensibilidadMouse = 15;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputRot.x = Input.GetAxis("Mouse X") * sensibilidadMouse;
        
    }


    public void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(0, InputRot.x, 0);

    }
}
