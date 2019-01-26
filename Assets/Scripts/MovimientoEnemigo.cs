using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad = 10f;
    public bool siguiendo = true;
    public float rangoDeteccion = 10f;
    public float rangoAtaque = 1.5f;
    Nucleo nucleo;
    NavMeshAgent agent;
    public float cooldown = 1.5f;
    public float cooldownTimer;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        nucleo = FindObjectOfType<Nucleo>();
        agent.speed = velocidad;
        //SonidoSierna();
    }

    void FixedUpdate()
    {


        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
        }

        float distanciaAlnucleo = Vector3.Distance(transform.position, nucleo.transform.position);



        if (cooldownTimer == 0)
        {


            if (siguiendo == true)//Encontro al nucleo
            {
                if (distanciaAlnucleo > rangoAtaque)//Si el enemigo esta lejos del pj entonces solo lo sigo
                {


                    agent.destination = nucleo.transform.position;//NavMeshAgent.Warp(nucleo.transform.position);//
                    transform.LookAt(nucleo.transform.position);
                }
            }
        }
        else
        {
            siguiendo = false;
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

    void OnDrawGizmos()
    {

        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, rangoDeteccion);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoAtaque);
    }



    
}
