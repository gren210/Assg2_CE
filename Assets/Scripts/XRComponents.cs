/*
 * Author: Thaqif Adly Bin Mazalan
 * Date: 18/11/24
 * Description: Provides a base class for managing XR-related components, including interactables and transformers
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

public class XRComponents : MonoBehaviour
{
    /// <summary>
    /// The simple interactable component associated with this object.
    /// </summary>
    [HideInInspector]
    public XRSimpleInteractable simpleInteractable;

    /// <summary>
    /// The collider associated with the simple interactable.
    /// </summary>
    [HideInInspector] 
    public Collider sCollider;

    /// <summary>
    /// The grab interactable component associated with this object.
    /// </summary>
    [HideInInspector]
    public XRGrabInteractable grabInteractable;

    /// <summary>
    /// The collider associated with the grab interactable.
    /// </summary>
    [HideInInspector] 
    public Collider gCollider;
    

    /// <summary>
    /// Sets the enabled status of XR components for this object.
    /// </summary>
    /// <param name="simpleInt">Whether the simple interactable is enabled.</param>
    /// <param name="grabInt">Whether the grab interactable is enabled.</param>
    public virtual void XRComponentStatus(bool simpleInt, bool grabInt)
    {
        if (simpleInteractable != null) { simpleInteractable.enabled = simpleInt; }
        if (sCollider != null) { sCollider.enabled = simpleInt; }
        if (grabInteractable != null) { grabInteractable.enabled = grabInt; }
        if (gCollider != null) { gCollider.enabled = grabInt; }
    }

    /// <summary>
    /// Plays an audio clip using the provided audio source.
    /// </summary>
    /// <param name="source">The audio source to play the clip from.</param>
    /// <param name="clip">The audio clip to play.</param>
    protected virtual void PlayAudio(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
}

