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
           confirmarCompra.SetActive(true);
           saldo -= precio;
           etiquetaSaldo.text = saldo.ToString("000.00") + "€";

        }
        else 
        {
            sinSaldo.SetActive(true);
        }
    }
    public void SinSaldo()
    {
        sinSaldo.SetActive(false);
    }
    public void SiCompra()
    { 
        confirmarCompra.SetActive(true);
    }
    public void NoCompra()
    {
        confirmarCompra.SetActive(false);
    }
}
