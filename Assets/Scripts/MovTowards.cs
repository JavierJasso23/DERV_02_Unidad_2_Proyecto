using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTowards : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    [SerializeField]
    GameObject ObjDestino;
    [SerializeField]
    GameObject ObjAMover;

    Vector3 origen;
    Vector3 destino;
    int timer = 0;
    bool activo;
    float distancia = 0.0f; 

    // Start is called before the first frame update
    void Start()
    {
        activo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (activo)
        {
            Vector3 origen = ObjAMover.transform.position;
            Vector3 destino = ObjDestino.transform.position;

            ObjAMover.transform.LookAt(destino);

            destino.x -= 5.0f;
            //destino.z -= 10.0f;
            destino.y = 0.1f;
            origen.y = 0.1f;

            ObjAMover.transform.position = Vector3.MoveTowards(origen, destino, speed * Time.deltaTime);

            //transform.position = Vector3.Lerp(origen, destino, speed * Time.deltaTime);

            //Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
            //transform.position = Vector3.SmoothDamp(origen, destino,ref currentVelocity, speed * Time.deltaTime);

            distancia = Vector3.Distance(origen, destino);
            Debug.Log(distancia);
            if (distancia < 2.0f)
            {
                if (ObjAMover.transform.position.x < ObjDestino.transform.position.x - 5)
                {
                    activo = false;
                    StartCoroutine("corrutinaMov");
                }
            }
        }
        if (ObjDestino.transform.position.z > 83)
        {
            activo = false;
            StopCoroutine("corrutinaMov");
        }

    }

    IEnumerator corrutinaMov()
    {
        WaitForSeconds Wait = new WaitForSeconds(1.0f);

        while (true)
        {
            timer++;
            if (timer == 7)
            {
                activo = true;
                timer = 0;
                StopCoroutine("corrutinaMov");
            }

            yield return Wait;
        }
    }
}
