using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemOrderText : MonoBehaviour
{
    public bool isScannedItem;
    
    public TextMeshProUGUI quantityText;

    public TextMeshProUGUI productText;
    
    public TextMeshProUGUI packedText;

    public TextMeshProUGUI scannedText;

    public void SetText(int quantity, string product, int packed)
    {
        quantityText.text = quantity.ToString();
        productText.text = product;
        packedText.text = packed.ToString();
    }

    public void SetScannedText(string product, int scanned)
    {
        productText.text = product;
        scannedText.text = scanned.ToString();
    }
}
