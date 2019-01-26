using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    float VidaEnemigo = 100;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bala")
        {

            VidaEnemigo -= 10;
        }
    }
}
