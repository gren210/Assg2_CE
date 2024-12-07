using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private InputActionReference yButtonAction; // Reference to the Y button action

    private void OnEnable()
    {
        yButtonAction.action.performed += OnYButtonPressed;
        yButtonAction.action.Enable();
    }

    private void OnDisable()
    {
        yButtonAction.action.performed -= OnYButtonPressed;
        yButtonAction.action.Disable();
    }

    /// <summary>
    /// Function triggered when the Y button is pressed.
    /// </summary>
    /// <param name="context">Input action context containing details of the input.</param>
    private void OnYButtonPressed(InputAction.CallbackContext context)
    {
        Debug.Log("Y button pressed!");
        OnInfo();
    }
    
    void OnInfo()
    {
        GameObject UIobject = GameManager.instance.infoUI.UIObject;
        UIobject.SetActive(!UIobject.activeSelf);
        Debug.Log(UIobject.activeSelf);
    }

    void OnInfo2(GameObject UIObject)
    {
        UIObject.SetActive(!UIObject.activeSelf);
        Debug.Log(UIObject.activeSelf);
    }
}
