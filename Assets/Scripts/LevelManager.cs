using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
  float spawnTime = 6f;
  public GameObject enemigo;
  public GameObject[] poolSpawners;
  public float timeInvoke;
  public float repeatInvoke;
  public int contadorEnemigos = 0;
  void Start() {
    Invoke("InvocarMinion", spawnTime);
    InvokeRepeating("speedSpawning", 0f, 10f);
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
  void Invocacion() {
    if (contadorEnemigos <= 10) {
      contadorEnemigos += 1;
      //Instantiate(enemigos, transform.position, transform.rotation);
    }
  }
}
