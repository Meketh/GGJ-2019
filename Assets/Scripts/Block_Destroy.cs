using UnityEngine;
using System.Collections;

public class Block_Destroy : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    }
}
