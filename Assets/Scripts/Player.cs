using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public float velocidadRotacion = 100;
    public float velocidadTraslacion = 10;
    public GameObject Bala;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(0, velocidadRotacion * Time.deltaTime , 0);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate( 0, -velocidadRotacion * Time.deltaTime ,0 );
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0, 0, velocidadTraslacion * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0, 0,-velocidadTraslacion * Time.deltaTime);
        }

        if (Input.GetMouseButton(0))
        {
            Disparar();
            
        }
    }
    void Disparar()
    {
        Instantiate(Bala, transform.position, transform.rotation);
    }
}
