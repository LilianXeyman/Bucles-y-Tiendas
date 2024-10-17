using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EjemploBucle : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI numeroMedia;

    [SerializeField]
    TextMeshProUGUI numeroAlta;

    [SerializeField]
    TextMeshProUGUI numeroBaja;

    public int[] arrayNumeros;
    
    void Start()
    {
        int sumaDeNotas = 0;
        int notaMAlta = arrayNumeros[0];
        int notaMBaja = arrayNumeros[0];
        for (int i=0;i<arrayNumeros.Length;i++)
        {
            sumaDeNotas += arrayNumeros[i];
            Debug.Log("Nota en el ejercicio " + i + "=" + arrayNumeros[i]);
            //Debug.Log("Media notas = " + (arrayNumeros[i] / arrayNumeros.Length)); Falta poner el sumatorio de todos los valores del array
            if (arrayNumeros[i] > notaMAlta)
            {
                notaMAlta = arrayNumeros[i];
            }
            if (arrayNumeros[i] < notaMBaja)
            {
                notaMBaja = arrayNumeros[i];
            }
        }

        int notaMedia = sumaDeNotas / arrayNumeros.Length;
        Debug.Log("Media notas = " + notaMedia);
        numeroMedia.text = notaMedia.ToString();
        Debug.Log("Nota más alta = " + notaMAlta);
        numeroAlta.text = notaMAlta.ToString();
        Debug.Log("Nota más baja = " + notaMBaja);
        numeroBaja.text = notaMBaja.ToString();
    }

    void Update()
    {
        
    }
}
