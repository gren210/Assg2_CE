/*
 * Author: Thaqif Adly Bin Mazalan
 * Date: 18/11/24
 * Description: Handles user interface interactions in the AR cooking game, including scene transitions and dynamic UI adjustments based on player actions.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    /// <summary>
    /// Determines if the UI should face the player or origin object.
    /// </summary>
    public bool isLookAt;

    /// <summary>
    /// The pause menu UI GameObject.
    /// </summary>
    public GameObject pauseUI;

    /// <summary>
    /// Bool to check if the toggle is on or off
    /// </summary>
    private bool volumeToggleBool;
    
    /// <summary>
    /// Toggle button for the volume
    /// </summary>
    public Toggle volumeToggle;

    public Animator transitionAnimator;
    

    /// <summary>
    /// Starts the game by loading the game scene and updating the instruction text.
    /// </summary>
    public void StartGame()
    {
    }

    IEnumerator LoadLevel(int levelInt)
    {
        transitionAnimator.SetTrigger("Transition");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Returns to the main menu by loading the main menu scene.
    /// </summary>
    public void MainMenu()
    { 
        StartCoroutine(LoadLevel(1));
    }

    public void Quit()
    {
        Application.Quit();
    }

    /// <summary>
    /// Method for pausing the game
    /// </summary>
    public void PauseButton()
    {
        if (pauseUI.activeSelf)
        {
            Time.timeScale = 1f;
        }
        else
        {
            Time.timeScale = 0f;
        }
        pauseUI.SetActive(!pauseUI.activeSelf);
    }

    void Start()
    {
        AudioListener.volume = 1f;
    }

    /// <summary>
    /// Updates the UI's orientation if `isLookAt` is enabled.
    /// </summary>
    void Update()
    {
        if (isLookAt)
        {
            //gameObject.transform.LookAt(GameManager.instance.origin.transform);
        }
    }

    /// <summary>
    /// Method for adjusting volume.
    /// </summary>
    public void VolumeButton()
    {
        volumeToggleBool = !volumeToggle.isOn; // Invert the toggle's "isOn" value for muted state
        AudioListener.volume = volumeToggleBool ? 0 : 1;
    }
    
    
}