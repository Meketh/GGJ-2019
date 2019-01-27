using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrenderYApagarGameOver : MonoBehaviour
{
    public Text textoGameOver;
    public Text textoLore;
    public Text textoRetry;
    
    private void Start()
    {
        textoGameOver.enabled = false;
        textoLore.enabled = false;
        textoRetry.enabled = false;

        FuncionLore();
        Invoke("FuncionGameOveryRetry", 7f);

    }

    private void Update()
    {
        
    }


    void FuncionLore()
    {
        textoLore.enabled = true;      
    }

    void FuncionGameOveryRetry()
    {
        textoLore.enabled = false;
        textoGameOver.enabled = true;
        textoRetry.enabled = true;
    }

}
