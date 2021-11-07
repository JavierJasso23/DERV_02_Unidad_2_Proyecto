using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main_3 : MonoBehaviour
{
    [SerializeField]
    GameObject activarDialogoFinal;

    private void OnTriggerEnter(Collider other)
    {
        activarDialogoFinal.SetActive(true);
    }

}
