using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class BarcodeScan : XRComponents
{
    public Transform scanOrigin;

    public float scanRange;
    
    AudioSource audioSource;

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        audioSource = GetComponent<AudioSource>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScanItem()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(scanOrigin.position, scanOrigin.forward, out hitInfo, scanRange);
        if (hit)
        {
            if (hitInfo.transform.tag == "Item")
            {
                audioSource.Play();
                //hitInfo.collider.gameObject.SetActive(false);
            }
        }
    }
    
    
}
