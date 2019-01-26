using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemigos : MonoBehaviour
{
    public GameObject enemigos;
    public float timeInvoke;
    public float repeatInvoke;
    public int contadorEnemigos = 0;
    

    private void Start()
    {
            InvokeRepeating("Invocacion", timeInvoke, repeatInvoke);
    }

    private void Update()
    {

    }

    void Invocacion()
    {

        if (contadorEnemigos <= 10)
        {
            contadorEnemigos += 1;
            Instantiate(enemigos, transform.position, transform.rotation);
        }

       
    }
}
