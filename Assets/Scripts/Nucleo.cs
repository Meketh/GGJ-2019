using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleo : MonoBehaviour
{
    public int vidaNucleo = 100;
    public int golpebicho = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            vidaNucleo -= golpebicho;
        }
    }
}
