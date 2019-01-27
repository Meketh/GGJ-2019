using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptWIN : MonoBehaviour
{
    public Text tamaraText;
    public Text soulsText;
    public Text loreText;


    public GameObject botonTamara;
    public GameObject botonSouls;
    public LevelManager levelManager;

    private void Start()
    {
        tamaraText.enabled = false;
        soulsText.enabled = false;

    }

    public void prenderTextTamara()
    {
        if (levelManager.podesGanar) { 

            tamaraText.enabled = true;
            loreText.enabled = false;
            botonSouls.SetActive(false);
            botonTamara.SetActive(false);
        }

    }

    public void prenderTextSouls()
    {
        if (levelManager.podesGanar)
        {
            soulsText.enabled = true;
            loreText.enabled = false;
            botonSouls.SetActive(false);
            botonTamara.SetActive(false);
        }
    }

}
