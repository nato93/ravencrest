using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{

    public AudioSource audioSource;

    public AudioClip stepSound;
    public AudioClip attackSound;
    public AudioClip jumpSound;


    // Start is called before the first frame update
    public void AE_JumpSound(float volume)
    {
        audioSource.volume = volume;

        audioSource.PlayOneShot(jumpSound);
    }

    public void AE_StepSound(float volume)
    {
        audioSource.volume = volume;
        audioSource.PlayOneShot(stepSound);
    }
    public void AE_AttackSound(float volume)
    {
        audioSource.volume = volume;

        audioSource.PlayOneShot(attackSound);
    }
}
