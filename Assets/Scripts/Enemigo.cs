using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int VidaEnemigo = 100;
    public int ataqueEnemigo = 100;
    AudioSource sourceAudio;
    SoundManager soundScrpt;

    private void Start()
    {
        sourceAudio = FindObjectOfType <AudioSource>().GetComponent<AudioSource>();
        soundScrpt = FindObjectOfType<SoundManager>().GetComponent<SoundManager>();
    }


    private void Update()
    {
        if(VidaEnemigo <= 0)
        {
            sourceAudio.PlayOneShot(soundScrpt.clipGrito, 0.5f);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
          var bala = other.gameObject.GetComponent<MovimientoBala>();
          VidaEnemigo -= bala.danio;
        }
    }
}
