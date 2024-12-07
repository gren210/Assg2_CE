using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    public Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            other.transform.SetParent(parent);
            if (GameManager.instance.currentItems.Contains(other.GetComponent<Item>().name))
            {
                int index = GameManager.instance.currentItems.IndexOf(other.GetComponent<Item>().name);
                GameManager.instance.currentQuantity[index]++;
            }
            else
            {
                GameManager.instance.currentItems.Add(other.GetComponent<Item>().name);
                GameManager.instance.currentQuantity.Add(1);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            other.transform.SetParent(null);
            int index = GameManager.instance.currentItems.IndexOf(other.GetComponent<Item>().name);
            if (GameManager.instance.currentQuantity[index] == 1)
            {
                GameManager.instance.currentQuantity.Remove(index);
            }
        }
    }
}
