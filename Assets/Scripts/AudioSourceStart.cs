using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceStart : MonoBehaviour
{
    public AudioSource Sound;

    public void PlaySound()
    {
        Sound.Play();
    }
}
