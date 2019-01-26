using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    float frecuenciaAparicionAutos = 3f;
    float delayParaEmpezar = 1f;
    public GameObject enemigo;
    public GameObject[] poolSpawners;

    void Start()
    {
        InvokeRepeating("InvocarAuto", delayParaEmpezar, frecuenciaAparicionAutos);
    }

    public void InvocarAuto()
    {
        GameObject.Instantiate(enemigo, //transform.position, transform.rotation);
            poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.position,
            poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.rotation);

    }
}
