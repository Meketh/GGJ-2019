using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance;
    private AudioSource audioSource;
    public AudioClip clipBackground;
    public AudioClip clipMisil;
    public AudioClip clipGrito;
    public AudioClip clipRezo;
    public AudioClip clipRisa;
    public AudioClip clipRisa2;
    public AudioClip clipGameOver;
    

    void Awake()//Inicializa scripts/variables que lo van a utilizar por ejemplo Start. Primero pasa por todos los Awake.
    {
        if (Instance == null)
        {
            Instance = this; //this, hace referencia a este script.
            DontDestroyOnLoad(gameObject);// No te destruyas, a este objeto.El objeto seria el que contiene el script.

        }
        else
        {
            Destroy(gameObject);

        }

        audioSource = GetComponent<AudioSource>();
        playBackground(clipBackground);

    }

    public void playBackground(AudioClip clip)
    {
        audioSource.PlayOneShot(clip, 0.1f);

    }

    public void playAudio(AudioClip clip, float vol = 1f)
    {
        audioSource.PlayOneShot(clip, vol);

    }
}
