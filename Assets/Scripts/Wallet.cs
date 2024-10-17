using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    [SerializeField]
    float saldo;

    [SerializeField]
    TextMeshProUGUI etiquetaSaldo;

    [SerializeField]
    GameObject confirmarCompra;

    [SerializeField]
    GameObject sinSaldo;

    // Start is called before the first frame update
    void Start()
    {
        
        saldo = Random.Range(450f, 950f);
        etiquetaSaldo.text = saldo.ToString("000.00") + "€";
    }

    public void RestarSaldo(float precio)
    {
        if (saldo > precio)
        {
            saldo -= precio;
            etiquetaSaldo.text = saldo.ToString("000.00") + "€";
        }
        else 
        {
            sinSaldo.SetActive(true);
        }
    }
}
