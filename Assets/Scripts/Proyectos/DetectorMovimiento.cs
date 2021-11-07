using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetectorMovimiento : MonoBehaviour
{

    [SerializeField]
    Transform Player;
    [SerializeField]
    Transform Respawn;

    int timer = 0;
    int muertes = 0;

    float PosAnterior;
    float PosActual;

    void Start()
    {
        PlayerPrefs.SetInt("Muertes", muertes);

        empezar();
    }

    void empezar()
    {
        StartCoroutine("CorrutinaTimer");
    }

    IEnumerator CorrutinaTimer()
    {
        WaitForSeconds Wait = new WaitForSeconds(1.0f);
        while (true)
        {
            timer++;

            if (timer == 5)
            {
                PosAnterior = Player.position.z;
            }

            if (timer > 5 && timer < 10)
            {
                PosActual = Player.position.z;
                if (PosActual > PosAnterior)
                {
                    PlayerPrefs.SetInt("Muertes", muertes++);
                    PlayerPrefs.Save();
                    Player.position = Respawn.position;
                    PosAnterior = Player.position.z;
                }
            }

            if (timer == 9)
            {
                timer = 0;
            }

            if (Player.position.z > 83.0f)
            {
                StopCoroutine("CorrutinaTimer");
            }

            yield return Wait;
        }
    }
}
