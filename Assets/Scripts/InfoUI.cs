using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InfoUI : MonoBehaviour
{
    
    public List<ItemOrderText> itemTextList = new List<ItemOrderText>();
    
    [HideInInspector]
    public List<string> currentItems = new List<string>();
    
    [HideInInspector]
    public List<int> currentQuantity = new List<int>();

    public int maxItemCount;

    public int maxQuantityCount;
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.infoUI = this;
        RandomiseItems();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomiseItems()
    {
        //int itemCount = Random.Range(2, maxItemCount+1);
        int quantityCount = Random.Range(1, maxQuantityCount+1);
        for (int i = 0; i < quantityCount; i++)
        {
            int itemIndex = Random.Range(0, GameManager.instance.itemsList.Length);
            string chosenItem = GameManager.instance.itemsList[itemIndex];
            if (currentItems.Contains(chosenItem))
            {
                int chosenIndex = currentItems.IndexOf(chosenItem);
                currentQuantity[chosenIndex]++;
            }
            else
            {
                currentItems.Add(GameManager.instance.itemsList[itemIndex]);
                currentQuantity.Add(1);
            }
        }
        UpdateText();
    }

    public void UpdateText()
    {
        for (int i = 0; i < currentItems.Count; i++)
        {
            ItemOrderText itemText = itemTextList[i];
            //itemText.quantityText.text = currentQuantity[i].ToString();
            //itemText.productText.text = currentItems[i];
            //itemText.packedText.text = "0";
            itemText.SetText(currentQuantity[i], currentItems[i], 0);
        }
    }
}
