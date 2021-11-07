using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_Code : MonoBehaviour
{

    [SerializeField]
    GameObject objMirar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(objMirar.transform);
        //Vector3 posMirar = new Vector3(2f, 0f, 5f);

        Vector3 pos = objMirar.transform.position;
        pos.y = 0;
        transform.LookAt(pos);
        //transform.LookAt(posMirar);
    }
}
