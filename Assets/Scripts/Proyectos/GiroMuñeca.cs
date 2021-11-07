using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroMuñeca : MonoBehaviour
{
    [SerializeField]
    Transform Muñeca;

    GameObject PL;
    int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        PL = GameObject.Find("Jugador");
        Empezar();
    }

    void Empezar()
    {
        StartCoroutine("CorrutinaGiro");
    }

    IEnumerator CorrutinaGiro()
    {
        WaitForSeconds Wait = new WaitForSeconds(1.0f);
        while (true)
        {
            timer++;
            if (timer == 5)
            {
                Muñeca.rotation = Quaternion.Euler(-90f,180f,0f);
            }

            if (timer == 9)
            {
                Muñeca.rotation = Quaternion.Euler(-90f, 0f, 0f);
                timer = 0;
            }

            if (PL.transform.position.z > 83.0f)
            {
                StopCoroutine("CorrutinaGiro");
            }

            yield return Wait;
        }
        
    }

}
