using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour {
  public int velocidad = 150;
  public int danio = 50;
  public float ttl = 5;
  void Update() {
    gameObject.transform.Translate(0f, 0f, velocidad * Time.deltaTime);
    ttl -= Time.deltaTime;
    if (ttl <= 0f) {
      Destroy(gameObject);
    }
  }
  private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag == "PLAYER") {
      Destroy(gameObject);
    }
  }
}
