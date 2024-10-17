using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonShop : MonoBehaviour
{
    //[SerializeField]
    TextMeshProUGUI textButton;

    [SerializeField]
    Wallet myWallet;

    [SerializeField]
    string nameItem = "Objeto";

    [SerializeField]
    float priceItem;

    void Start()
    {
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();//Estas diciendo que el nombre del botón sea el mismo que el del nombre del "hijo" en donde los game objects
        priceItem = Random.Range(25f,350f);
        textButton.text = priceItem.ToString() + "€";
    }
    public void ClickEnBotonTienda()
    {
        myWallet.RestarSaldo(priceItem);
    }
}
