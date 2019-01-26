using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivadorBloques : MonoBehaviour
{

    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bloques" && Input.GetKey(KeyCode.Mouse1))
        {
            collision.gameObject.SetActive(false);
        }
    }


}
