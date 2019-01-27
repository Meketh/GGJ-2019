using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BulletType { Normal, Scatter, Rapid, Fragment }

public class PowerUp : MonoBehaviour {
  public BulletType bulletType = BulletType.Rapid;
  public float ttl = 30f;
  void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "Player") {
      Destroy(gameObject);
    }
  }
}
