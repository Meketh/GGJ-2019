using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
  float spawnTime = 6f;
  public GameObject enemigo;
  public GameObject[] poolSpawners;
  public int contadorEnemigos = 0;
    public int contadorEnemigosParaRisaPlayer = 0;
    public int cantidadEnemigosParaReirte = 5;
    public int cantidadEnemigosParaGanar = 100;

    public Canvas canvasGameOver;
    PrenderYApagarGameOver scriptGameOver;


    Nucleo nucleoScript;

    void Start()
    {
        Invoke("InvocarMinion", spawnTime);
        InvokeRepeating("speedSpawning", 0f, 10f);
        nucleoScript = FindObjectOfType<Nucleo>().GetComponent<Nucleo>();
        scriptGameOver = FindObjectOfType<PrenderYApagarGameOver>().GetComponent<PrenderYApagarGameOver>();
       
        scriptGameOver.enabled = false;
        canvasGameOver.enabled = false;
    }
    private void Update()
    {
        if(contadorEnemigosParaRisaPlayer == cantidadEnemigosParaReirte)// RISA PLAYER
        {
            contadorEnemigosParaRisaPlayer = 0;
            SoundManager.Instance.playRisaPlayer();
        }
        if (contadorEnemigos >= cantidadEnemigosParaGanar)
        {
            SceneManager.LoadScene("Victoria");            
        }
        if (nucleoScript.vidaNucleo <= 0)
        {
            canvasGameOver.enabled = true;
            scriptGameOver.enabled = true;
        }

    }
    public void speedSpawning() {
    spawnTime = Mathf.Max(.5f, spawnTime - 1f);
  }
  public void InvocarMinion() {
    Invoke("InvocarMinion", spawnTime);
    Instantiate(enemigo, //transform.position, transform.rotation);
      poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.position,
      poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.rotation);
  }
}
