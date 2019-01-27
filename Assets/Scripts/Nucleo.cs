using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleo : MonoBehaviour
{
    public float vidaNucleo = 100;

    private void Update()
    {
        if(vidaNucleo <= 0)
        {
            vidaNucleo = 0;
        }
    }

}
