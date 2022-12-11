using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic(float volume)
    {

        if (_audioSource.isPlaying) return;
        _audioSource.volume = volume;
        _audioSource.Play();

    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
}