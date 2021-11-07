using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTowards : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    int timer = 0;
    Vector3 origen;
    Vector3 destino;

    // Start is called before the first frame update
    void Start()
    {
        empezar();
    }
    void empezar()
    {
        StartCoroutine("CorrutinaBot");
    }

    // Update is called once per frame
    /*void Update()
    {        
        Vector3 origen = transform.position;
        Vector3 destino = ObjDestino.transform.position;
        
        transform.LookAt(destino);

        destino.x -= 10.0f;
        //destino.z -= 10.0f;
        

        transform.position =  Vector3.MoveTowards(origen, destino, speed * Time.deltaTime);

        //transform.position = Vector3.Lerp(origen, destino, speed * Time.deltaTime);

        //Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
        //transform.position = Vector3.SmoothDamp(origen, destino,ref currentVelocity, speed * Time.deltaTime);

        float distancia = Vector3.Distance(origen, destino);
        Debug.Log(distancia);

    }*/

    IEnumerator CorrutinaBot()
    {
        WaitForSeconds Wait = new WaitForSeconds(1.0f);
        while (true)
        {
            timer++;

            if (timer == 5)
            {
                transform.LookAt(destino);
                destino.x -= 10.0f;
                transform.position = Vector3.MoveTowards(origen, destino, speed * Time.deltaTime);
            }

            if (timer == 9)
            {
                timer = 0;
            }

            if (this.transform.position.z > 85.0f)
            {
                StopCoroutine("CorrutinaTimer");
            }

            yield return Wait;
        }
    }

}
