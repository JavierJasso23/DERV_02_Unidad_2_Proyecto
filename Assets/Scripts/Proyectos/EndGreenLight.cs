using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGreenLight : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    AudioSource soundGame;
    [SerializeField]
    GameObject DesactivarGiro;
    [SerializeField]
    GameObject ActivarDialogoFinal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("Apagado");
            soundGame.Stop();
            soundGame.enabled = false;
            DesactivarGiro.SetActive(false);
            ActivarDialogoFinal.SetActive(true);
        }
    }

}
