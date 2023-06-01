using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AMTwo : MonoBehaviour
{
    public Sound[] sounds;
    void Awake()
    {

        foreach (Sound s in sounds)
        {

            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;



        }

    }

    void Start()
    {

        Play("MainMenuTheme");

    }

    public void ButtonPress()
    {

        Play("ButtonPress");

    }

    public void FlappyNat()
    {

        Play("FlappyNat");

    }

    public void Play(string Name)
    {

        Sound s = Array.Find(sounds, sound => sound.name == Name);

        if (s == null)
        {

            Debug.LogWarning("Sound" + Name + "Is Not Found");
            return;

        }



        s.source.Play();


    }
}
