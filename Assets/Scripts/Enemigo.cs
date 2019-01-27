using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int VidaEnemigo = 100;
    
    AudioSource sourceAudio;
    SoundManager soundScirpt;
    int grito;

    private void Start()
    {
        sourceAudio = FindObjectOfType<AudioSource>().GetComponent<AudioSource>();
        soundScirpt = FindObjectOfType<SoundManager>().GetComponent<SoundManager>();
        
    }


    private void Update()
    {
        if(VidaEnemigo <= 0)
        {
            ElegirSonidoGrito();
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
    public void ElegirSonidoGrito()
    {
        int grito = Random.Range(0, soundScirpt.clipGrito.Length);
        SoundManager.Instance.playAudio(soundScirpt.clipGrito[grito], 0.1f);
    }
}
