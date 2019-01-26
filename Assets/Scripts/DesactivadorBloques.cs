using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivadorBloques : MonoBehaviour
{

    public LayerMask blockLayers;
    
    void FixedUpdate()
    {
        Lala();
    }

    void Lala()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 5, blockLayers)) //Choca solo con el layer que le tiras en el editor como BlockLayer.
        {
            //print(hitInfo.collider);

            if ( Input.GetKey(KeyCode.Mouse1))
            {
                hitInfo.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                hitInfo.collider.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            }
            if (Input.GetKey(KeyCode.R))
            {
                hitInfo.collider.gameObject.GetComponent<MeshRenderer>().enabled = true;
                hitInfo.collider.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            }

        }
    }

}
