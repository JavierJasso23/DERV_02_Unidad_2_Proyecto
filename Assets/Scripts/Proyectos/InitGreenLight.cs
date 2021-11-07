using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGreenLight : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    AudioSource soundGame;
    [SerializeField]
    GameObject ActivarGiro;
    [SerializeField]
    GameObject ActivarDetectorMov;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("Encendido");
            soundGame.enabled = true;
            soundGame.Play();
            ActivarGiro.SetActive(true);
            ActivarDetectorMov.SetActive(true);
        }
        this.gameObject.SetActive(false);

    }

}
