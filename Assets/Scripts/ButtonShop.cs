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
    // Start is called before the first frame update
    void Start()
    {
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f,350f);
        textButton.text = priceItem.ToString() + "€";
    }
    public void ClickEnBotonTienda()
    {
        myWallet.RestarSaldo(priceItem);
    }
}
