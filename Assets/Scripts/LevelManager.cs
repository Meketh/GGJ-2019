using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    float frecuenciaAparicionMinion = 3f;
    float delayParaEmpezar = 1f;
    public GameObject enemigo;
    public GameObject[] poolSpawners;
    public float timeInvoke;
    public float repeatInvoke;
    public int contadorEnemigos = 0;

    void Start()
    {
        InvokeRepeating("InvocarMinion", delayParaEmpezar, frecuenciaAparicionMinion);
    }

    public void InvocarMinion()
    {
        print("invocar minion");
        Instantiate(enemigo, //transform.position, transform.rotation);
            poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.position,
            poolSpawners[Random.Range(0, poolSpawners.Length - 1)].transform.rotation);

    }


    void Invocacion()
    {

        if (contadorEnemigos <= 10)
        {
            contadorEnemigos += 1;
            //Instantiate(enemigos, transform.position, transform.rotation);
        }


    }
}
