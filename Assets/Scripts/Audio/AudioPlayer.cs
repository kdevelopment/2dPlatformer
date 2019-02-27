using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    Fireball fireball;

    public AudioSource Footstep;
    public AudioSource mainTrack;
    public AudioSource Sizzle;

    public void PlayFootstep()
    {
        Footstep.Play();
    }
    public void PlaymainTrack()
    {
        mainTrack.Play();
    }
    public void PlaySizzle()
    {
        Sizzle.Play();
    }

    private void Start()
    {
        PlaymainTrack();

        fireball = GetComponent<Fireball>();
        
    }
    private void Update()
    {
        bool didfireball = fireball.fireballed;
        if (didfireball) {
            PlaySizzle();
            fireball.fireballed = false;

        }
    }

}


