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
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Item")
        {
            other.transform.SetParent(null);
        }
    }
}
