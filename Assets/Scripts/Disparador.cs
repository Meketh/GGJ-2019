using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviou {
  public GameObject Bala;
  public float cooldown = 1.5f;
  public float cooldownTimer = 0f;
  void Update() {
    if (cooldownTimer > 0) {
      cooldownTimer -= Time.deltaTime;
    } else if (cooldownTimer <= 0f && Input.GetMouseButton(0)) {
      cooldownTimer = 0.5f;
      Instantiate(Bala, transform.position, transform.rotation);
    }
  }
}
