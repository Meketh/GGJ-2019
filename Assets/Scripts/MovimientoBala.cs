using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour {
  public int velocidad = 150;
  public int danio = 50;
  public float ttl = 3;
  void Update() {
    gameObject.transform.Translate(0f, 0f, velocidad * Time.deltaTime);
    Invoke("destroyGameObject", ttl);
  }
  private void destroyGameObject() {
    Destroy(gameObject);
  }
  private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag != "Player") {
      destroyGameObject();
    }
  }
}
