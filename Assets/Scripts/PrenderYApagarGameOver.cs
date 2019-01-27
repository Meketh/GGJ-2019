using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrenderYApagarGameOver : MonoBehaviour
{
    public Text textoGameOver;
    public Text textoLore;
    public Text textoRetry;
    public bool invokeLore = false;
    public LevelManager levelManager;

    private void Start()
    {
        if(levelManager.podesPerder)
        {
            textoGameOver.enabled = false;
            textoLore.enabled = false;
            textoRetry.enabled = false;

            FuncionLore();
        }

    }

    private void Update()
    {
        if (invokeLore == true)
        {
            Invoke("FuncionGameOveryRetry", 7f);
            invokeLore = false;
        }
    }


    void FuncionLore()
    {
        textoLore.enabled = true;
        invokeLore = true;
    }

    void FuncionGameOveryRetry()
    {
        textoLore.enabled = false;
        textoGameOver.enabled = true;
        textoRetry.enabled = true;
    }

}
