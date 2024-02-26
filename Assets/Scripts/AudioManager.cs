using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmaudioSource;
    public GameObject sfxaudioSource; 

    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmaudioSource.Play();
    }

    public void PlaySFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxaudioSource, spawnPosition, Quaternion.identity);
    }

}


