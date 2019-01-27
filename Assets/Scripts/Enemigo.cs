using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int VidaEnemigo = 100;
    
    AudioSource sourceAudio;
    SoundManager soundScirpt;
    LevelManager levelManager;
    public GameObject particulasMuerte;
    bool paso = false;
    int grito =0;

    private void Start()
    {
        sourceAudio = FindObjectOfType<AudioSource>().GetComponent<AudioSource>();
        soundScirpt = FindObjectOfType<SoundManager>().GetComponent<SoundManager>();
        levelManager = FindObjectOfType<LevelManager>().GetComponent<LevelManager>(); ;
    }


    private void Update()
    {
        if(VidaEnemigo <= 0)
        {
            if (!paso)
            {
                Instantiate(particulasMuerte, transform.position, transform.rotation);
                ElegirSonidoGrito();
                paso = true;
                print(levelManager.contadorEnemigosParaRisaPlayer);
                levelManager.contadorEnemigosParaRisaPlayer += 1;
                levelManager.contadorEnemigos++;
                print(levelManager.contadorEnemigos);
            }
            Destroy(gameObject, 0.4f);

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
