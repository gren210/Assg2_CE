using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;

    public TextMeshProUGUI timerText;

    private float currentTime;

    private string placeholder;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.FloorToInt(currentTime % 60f) < 10f)
        {
            placeholder = "0";
        }
        else
        {
            placeholder = "";
        }
        timerText.text = Mathf.FloorToInt(currentTime / 60f) + ":" + placeholder + Mathf.FloorToInt(currentTime % 60f);

        if (currentTime <= 0)
        {
            GameManager.instance.gameOver = true;
            GameManager.instance.playerUI.EndGame();
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}
