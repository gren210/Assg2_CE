using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// An instance of the GameManager so that all scripts can access the GameManager.
    /// </summary>
    public static GameManager instance;

    public UI playerUI;
    
    public InfoUI infoUI;
    
    public ScannedUI scannedUI;

    public string[] itemsList;

    public bool gameOver;
    
    [HideInInspector]
    public List<string> currentItems = new List<string>();
    
    [HideInInspector]
    public List<int> currentQuantity = new List<int>();
    
    
    
    /// <summary>
    /// This Awake function ensures that there is only one instance of the GameManager.
    /// </summary>
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
