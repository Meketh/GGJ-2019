using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float VidaEnemigo = 100f;

    private void Update()
    {
        if(VidaEnemigo <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bala")
        {
            print(other);
            VidaEnemigo -= 100f;
        }
    }
}
