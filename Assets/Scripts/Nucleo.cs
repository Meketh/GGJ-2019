using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleo : MonoBehaviour
{
    public float vidaNucleo = 100;
    Enemigo enemigoScript;

    private void Start()
    {
        enemigoScript = FindObjectOfType<Enemigo>().GetComponent<Enemigo>();
    }

    private void Update()
    {
        if(vidaNucleo <= 0)
        {
            vidaNucleo = 0;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Enemigo")
    //    {
    //        vidaNucleo -= 0.05f;
    //    }
    //}
}
