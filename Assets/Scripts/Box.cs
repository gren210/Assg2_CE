using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject tapedBox;

    public GameObject parent;
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
        if (other.tag == "Tape")
        {
            other.GetComponent<Tape>().currentBox = this;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tape")
        {
            other.GetComponent<Tape>().currentBox = null;
        }
    }

    public void TapeBox()
    {
        Instantiate(tapedBox, transform.position, transform.rotation);
        parent.SetActive(false);
        Destroy(gameObject);
    }
    
}
