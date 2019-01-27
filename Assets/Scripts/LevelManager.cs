using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class LevelManager : MonoBehaviour {
  float spawnTime = 6f;
  public GameObject enemigo;
  public GameObject[] poolSpawners;
  public int contadorEnemigos = 0;
    public int contadorEnemigosParaRisaPlayer = 0;
    public int cantidadEnemigosParaReirte = 5;
    public int cantidadEnemigosParaGanar = 100;

    public Canvas canvasGameOver;
    public Canvas canvasWin;

    public CinemachineVirtualCamera victoryCam;

    public Animator anim;
    bool personajeSeRio = true;

    PrenderYApagarGameOver scriptGameOver;
    public Player player;

    Nucleo nucleoScript;

    public bool podesGanar = true;
    public bool podesPerder = true;

    void Start()
    {
        player.enabled = true;
        Invoke("InvocarMinion", spawnTime);
        InvokeRepeating("speedSpawning", 0f, 10f);
        nucleoScript = FindObjectOfType<Nucleo>().GetComponent<Nucleo>();
        scriptGameOver = FindObjectOfType<PrenderYApagarGameOver>().GetComponent<PrenderYApagarGameOver>();
        //player = FindObjectOfType<Player>().GetComponent<Player>();
        scriptGameOver.enabled = false;
        canvasGameOver.enabled = false;
        canvasWin.enabled = false;
    }
    private void Update()
    {
        if(contadorEnemigosParaRisaPlayer == cantidadEnemigosParaReirte)// RISA PLAYER
        {
            contadorEnemigosParaRisaPlayer = 0;
            SoundManager.Instance.playRisaPlayer();
        }
        if (contadorEnemigos >= cantidadEnemigosParaGanar && podesGanar) //GANASTE
        {
            podesGanar = true;
            podesPerder = false;
            canvasWin.enabled = true;
            victoryCam.enabled = true;


            anim.SetBool("Victory", true);
            player.enabled = false;
            if (personajeSeRio) { 
            SoundManager.Instance.playRisaPlayer();
                personajeSeRio = false;
            }
        }
        if (nucleoScript.vidaNucleo <= 0 && podesPerder)//PERDISTE
        {
            podesGanar = false;
            podesPerder = true;
            canvasGameOver.enabled = true;
            scriptGameOver.enabled = true;
        }

    }
    public void speedSpawning() {
    spawnTime = Mathf.Max(1f, spawnTime - 1f);
  }
  public void InvocarMinion() {
    Invoke("InvocarMinion", spawnTime);
    Instantiate(enemigo, //transform.position, transform.rotation);
      poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.position,
      poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.rotation);
  }
}
