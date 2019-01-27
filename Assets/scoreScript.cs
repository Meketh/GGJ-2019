using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    int scoreText;
    public Text textoScore;
    LevelManager levelScript;

    private void Start()
    {
        levelScript = FindObjectOfType<LevelManager>().GetComponent<LevelManager>();
        scoreText = 0;
    }

    private void Update()
    {
        textoScore.text = levelScript.contadorEnemigos.ToString()+ " / 100";
    }


}
