using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlay2 : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayStart2()
    {
        audioSource.PlayOneShot(audioSource.clip);
    }
}
