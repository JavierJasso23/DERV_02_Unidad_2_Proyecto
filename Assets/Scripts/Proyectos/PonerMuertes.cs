using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PonerMuertes : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txtMuertes;

    int muertes;

    // Start is called before the first frame update
    void Start()
    {
        muertes = PlayerPrefs.GetInt("Muertes");
        Debug.Log("TOTAL: " + muertes);
        txtMuertes.text = "Total de muertes: " + muertes.ToString();
    }

}
