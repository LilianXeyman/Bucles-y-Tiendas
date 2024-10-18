using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonShop : MonoBehaviour
{
    //[SerializeField]
    TextMeshProUGUI textButton;

    [SerializeField]
    Wallet myWallet; //Al poner esto, cuando pongas en el código myWallet, estas diciendo que busque en el script Wallet 

    [SerializeField]
    string[] posibleNombres;

    [SerializeField]
    string nameItem = "Objeto";

    [SerializeField]
    float priceItem;

    [SerializeField]
    Vector2[] precio;
    void Start()
    {
        //Elegir un nombre de forma aleatoria para cada botón
        nameItem = posibleNombres[Random.Range(0, posibleNombres.Length)];
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();//Estas diciendo que el nombre del botón sea el mismo que el del nombre del "hijo" en donde los game objects
        priceItem = Random.Range(25f,350f);//Quiero asociar dentro de la aletoreidad del precio inicial, uno especifico dentro del rango aportado por el Vector 2[] precio
        textButton.text = nameItem + "\n" + priceItem.ToString() + "€";
    }
    public void ClickEnBotonTienda()
    {
        myWallet.InformarCompra(nameItem, priceItem);
    }
}
