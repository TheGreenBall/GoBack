using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;


    // Start is called before the first frame update
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

        Play("Theme");

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
