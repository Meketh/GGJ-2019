using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject Bala;
    public float cooldown = 1.5f;
    public float cooldownTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CooldownPararse();
        if (Input.GetMouseButton(0))
        {

            if (cooldownTimer == 0f)
            {
                Disparar();
                cooldownTimer = 0.5f;
            }


        }
    }
    public void CooldownPararse()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;

        }
        if (cooldownTimer < 0)
        {
            cooldownTimer = 0;
        }
    }
    public void Disparar()
    {
        Instantiate(Bala, transform.position, transform.rotation);
    }
}

