using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    public int velocidad = 150;
    public int danio = 50;

    void Update()
    {
        gameObject.transform.Translate(0f, 0f, velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
      Destroy(gameObject);
    }
}
