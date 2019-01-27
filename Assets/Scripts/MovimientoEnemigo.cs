using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad = 20f;
    public bool siguiendo = true;
    public float rangoDeteccion = 10f;
    public float rangoAtaque = 1.5f;
    public Nucleo nucleo;
    NavMeshAgent agent;
    public float cooldown = 1.5f;
    public float cooldownTimer;



    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        nucleo = FindObjectOfType<Nucleo>();
        agent.speed = velocidad;
        //velocidad = agent.speed;
    }

    void FixedUpdate()
    {

        float distanciaAlnucleo = Vector3.Distance(transform.position, nucleo.transform.position);
        



        if (siguiendo == true)
        {
            print(distanciaAlnucleo);

            if (distanciaAlnucleo > 20)//Si el enemigo esta lejos del fuego entonces lo sigo
            {
                agent.destination = nucleo.transform.position;//NavMeshAgent.Warp(nucleo.transform.position);//
                transform.LookAt(nucleo.transform.position);
                agent.isStopped = false;
            }
            else {
                agent.isStopped = true;
                siguiendo = false;
            }
        }
    }
    
}
