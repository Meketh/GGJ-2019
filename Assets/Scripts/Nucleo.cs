using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleo : MonoBehaviour
{
    public int hitTower=100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Enemigo"))
        {
            hitTower -= 10;
        }
    }
}
