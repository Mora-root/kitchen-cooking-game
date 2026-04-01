using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

[CreateAssetMenu()]
public class AudioClipRefsSO : ScriptableObject
{

    public AudioClip[] chop;
    public AudioClip[] deliveryFailed;
    public AudioClip[] deliverySuccess;
    public AudioClip[] footStep;
    public AudioClip[] objectDrop;
    public AudioClip[] objectPickup;
    public AudioClip stoveSizzle;
    public AudioClip[] trash;
    public AudioClip[] warning;

}
