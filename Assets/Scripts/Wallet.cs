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

    [SerializeField]//IMPORTANTE Añades una nueva variable que almacena el valor actual del objeto, el que vayas a clicar. 
    float precioActual;

    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f, 950f);
        etiquetaSaldo.text = saldo.ToString("000.00") + "€";
    }

    public void RestarSaldo(float precio)
    {
        precioActual = precio; // IMPORTANTE Le das el valor a la variable precioActual el valor del objeto calculado con el Random.Range, para que lo almacene y luego sea capaz de compararlo en el popUp confirmar compra
        if (saldo > precio)
        {
           confirmarCompra.SetActive(true);//Cuando se de esta condición se abrirá el popUp y, si le das a Sí te lleva a SiCompra, si le das a No te lleva a NoCompra
           /*saldo -= precio;
           etiquetaSaldo.text = saldo.ToString("000.00") + "€";*/
           //Cambias esto de aquía rriba para añadirlo al botón Sí para que se ejecute cuando confirmes la compra
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
        //En este caso pasaría a realizar la resta entre el saldo (asignado aleatoriamente) y el valor del precioActual, almacenado gracias a la variable. Con esto me refiero a que está guardando el valor del objeto que has clicado.
        saldo -= precioActual;
        etiquetaSaldo.text = saldo.ToString("000.00") + "€";
        confirmarCompra.SetActive(false);
        /*confirmarCompra.SetActive(true);
        RestarSaldo();*/
    }
    public void NoCompra()
    {
        confirmarCompra.SetActive(false);
    }
}
