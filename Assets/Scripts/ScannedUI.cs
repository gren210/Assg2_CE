using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedUI : MonoBehaviour
{
    public List<ItemOrderText> itemTextList = new List<ItemOrderText>();
    
    [HideInInspector]
    public List<string> currentItems = new List<string>();
    
    [HideInInspector]
    public List<int> currentQuantity = new List<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.scannedUI = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScannedItem(string itemName)
    {
        if (currentItems.Contains(itemName))
        {
            int chosenIndex = currentItems.IndexOf(itemName);
            currentQuantity[chosenIndex]++;
        }
        else
        {
            currentItems.Add(itemName);
            currentQuantity.Add(1);
        }
        UpdateText();
    }

    void UpdateText()
    {
        for (int i = 0; i < currentItems.Count; i++)
        {
            ItemOrderText itemText = itemTextList[i];
            itemText.SetScannedText(currentItems[i],currentQuantity[i]);
        }
    }
    
}
