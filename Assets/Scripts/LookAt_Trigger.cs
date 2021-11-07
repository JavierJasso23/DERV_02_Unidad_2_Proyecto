using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_Trigger : MonoBehaviour
{

    [SerializeField]
    GameObject objMirar;

    public Transform Enemigo;
    public Transform Reinicio;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 pos = objMirar.transform.position;
        pos.y = 0;
        Enemigo.LookAt(pos);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        Vector3 posMirar = new Vector3(4.56f, 0.73f, 6f);
        Reinicio.LookAt(posMirar);
    }


}
