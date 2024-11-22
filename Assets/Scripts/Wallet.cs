using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public static Wallet instance; //Esto es un singeltong(?) se hace para que todo haga referencia a este script
    [SerializeField]
    float saldo;
   
    [SerializeField]
    TextMeshProUGUI etiquetaSaldo;

    [SerializeField]
    GameObject confirmarCompra;

    [SerializeField]
    TextMeshProUGUI labelConfirmacion;

    [SerializeField]
    GameObject sinSaldo;

    [SerializeField]//IMPORTANTE A�ades una nueva variable que almacena el valor actual del objeto, el que vayas a clicar. 
    float precioActual;

    private void Awake()
    {
        if (Wallet.instance == null)//Comnprueba que el singeltone existe o no. En el caso de que no exista lo vas a crear
        {
            Wallet.instance = this;//Aqui pones que a lo que vas a hacer referencia con el this
        }
        else 
        {
            Destroy(this); //Con esto te qaseguras de que solo se ejecute una vez este script??????
        }
    }
    void Start()
    {
        saldo = Random.Range(450f, 950f);
        etiquetaSaldo.text = saldo.ToString("000.00") + "�";
    }

    public void InformarCompra(string nameItem, float precio)
    {
        precioActual = precio; // IMPORTANTE Le das el valor a la variable precioActual el valor del objeto calculado con el Random.Range, para que lo almacene y luego sea capaz de compararlo en el popUp confirmar compra
        if (saldo > precio)
        {
            labelConfirmacion.text = "�Quieres comprar " + nameItem + " por " + precio + " �";
            confirmarCompra.SetActive(true);//Cuando se de esta condici�n se abrir� el popUp y, si le das a S� te lleva a SiCompra, si le das a No te lleva a NoCompra
           //Cambias esto de aqu�a rriba para a�adirlo al bot�n S� para que se ejecute cuando confirmes la compra
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
        //En este caso pasar�a a realizar la resta entre el saldo (asignado aleatoriamente) y el valor del precioActual, almacenado gracias a la variable. Con esto me refiero a que est� guardando el valor del objeto que has clicado.
        if (saldo > precioActual)//El hecho de ponerlo entre los if es para reconfirmar que se va a ejecutar el c�digo de forma correcta. Es decir, te comprueba nuevamente que lo puedes comprar, antes de jacer la resta, le pone el valor 0 al objeto en el bot�n, de forma que no lo compres dos veces por error, y te desactiva el popUp
        {
            saldo -= precioActual;
            precioActual = 0.0f;
            etiquetaSaldo.text = saldo.ToString("000.00") + "�";
            confirmarCompra.SetActive(false);
        }
        else
        {
            confirmarCompra.SetActive(false);
            sinSaldo.SetActive(true);
        }
    }
    public void NoCompra()
    {
        confirmarCompra.SetActive(false);
    }
}
