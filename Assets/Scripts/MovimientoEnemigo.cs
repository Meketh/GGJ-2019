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
    public Nucleo nucleo;
    NavMeshAgent agent;
    public float cooldown = 0f;
    public float coolDownTimer = 2.0f;

    public int ataqueEnemigo = 1;

    public Animator anim;

    Enemigo enemigoScript;
    AudioSource sourceAudio;
    SoundManager soundScript;
    Nucleo nucleoScript;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        nucleo = FindObjectOfType<Nucleo>();
        anim = GetComponentInChildren<Animator>();
        agent.speed = velocidad;
        //velocidad = agent.speed;
        enemigoScript = GetComponent<Enemigo>();
        sourceAudio = FindObjectOfType<AudioSource>().GetComponent<AudioSource>();
        soundScript = FindObjectOfType<SoundManager>().GetComponent<SoundManager>();
        nucleoScript = FindObjectOfType<Nucleo>().GetComponent<Nucleo>();
    }

    void FixedUpdate()
    {

        float distanciaAlnucleo = Vector3.Distance(transform.position, nucleo.transform.position);

       
        if (siguiendo == true)
        {

            if (distanciaAlnucleo > agent.stoppingDistance)//Si el enemigo esta lejos del fuego entonces lo sigo
            {
                agent.destination = nucleo.transform.position;//NavMeshAgent.Warp(nucleo.transform.position);//
                transform.LookAt(nucleo.transform.position);
                agent.isStopped = false;
            }
            else
            {
                agent.isStopped = true;
                siguiendo = false;
                anim.SetBool("Rezo", true);
                
                InvokeRepeating("daniarNucleo", 0, 2);
                            
            //  Cooldown(); // quita vida 
            }
        }
    }

    public void daniarNucleo()
    {
        nucleoScript.vidaNucleo -= ataqueEnemigo;
        ElegirSonidoRezo();
    }

    /*public void Cooldown()
    {
        if (coolDownTimer > 0)
        {
            //sourceAudio.PlayOneShot(soundScript.clipRezo, .5f);
            nucleoScript.vidaNucleo -= ataqueEnemigo;
            coolDownTimer -= Time.deltaTime;
            print("pase");
            SoundManager.Instance.playAudio(soundScript.clipRezo, 0.01f);
        }
        if (coolDownTimer < 0)
        {
            coolDownTimer = 10;
        }
    }*/

    public void ElegirSonidoRezo()
    {
        int grito = Random.Range(0, soundScript.clipRezo.Length);
        SoundManager.Instance.playAudio(soundScript.clipRezo[grito], 0.1f);
    }

}
