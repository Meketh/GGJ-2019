using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int VidaEnemigo = 100;
    public int ataqueEnemigo = 100;

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
          var bala = other.gameObject.GetComponent<MovimientoBala>();
          VidaEnemigo -= bala.danio;
          Destroy(other.gameObject);
        }
    }
}
