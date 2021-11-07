using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PonerMuertes : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txtMuertes;

    // Start is called before the first frame update
    void Start()
    {
        txtMuertes.text = "Total de muertes "+PlayerPrefs.GetInt("Muertes").ToString();
    }

}
