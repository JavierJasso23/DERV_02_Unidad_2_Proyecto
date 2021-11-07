using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_2 : MonoBehaviour
{

    //public Canvas canv;
    public GameObject Respawn;
    public GameObject Player;
    int intentos;
    
    // Start is called before the first frame update
    void Start()
    {
        intentos = PlayerPrefs.GetInt("Muertes");
        Debug.Log("Muertes al momento - " + intentos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //GameObject obj = Instantiate(Player, Respawn.transform.position, Respawn.transform.rotation) as GameObject;
        Player.transform.position = Respawn.transform.position;
        intentos++;
        PlayerPrefs.SetInt("Muertes", intentos);
    }
}
