using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow_sound_play : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip AudioClip1;
    public AudioClip AudioClip2;


    private void OnTriggerEnter(Collider other)
    {
        if(Random.Range(0, 2) == 1)
        {
            AudioSource.clip = AudioClip1;
            AudioSource.Play();

        }
        if (Random.Range(0, 3) == 2)
        {
            AudioSource.clip = AudioClip2;
            AudioSource.Play();

        }
    }
}
