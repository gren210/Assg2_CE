using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemOrderText : MonoBehaviour
{
    public TextMeshProUGUI quantityText;

    public TextMeshProUGUI productText;
    
    public TextMeshProUGUI packedText;

    public void SetText(int quantity, string product, int packed)
    {
        quantityText.text = quantity.ToString();
        productText.text = product;
        packedText.text = packed.ToString();
    }
}
