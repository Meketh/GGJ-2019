using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVidaNucleo : MonoBehaviour
{
    Nucleo nucleoScript;
    Image imagenVerde;

    float vidaActual;
    float maxHealth;

    void Start()
    {
        nucleoScript = FindObjectOfType<Nucleo>().GetComponent<Nucleo>();
        imagenVerde = GetComponent<Image>();
        maxHealth = nucleoScript.vidaNucleo;
    }

    void Update()
    {
        vidaActual = nucleoScript.vidaNucleo;
        imagenVerde.fillAmount = vidaActual / maxHealth;

    }

}
