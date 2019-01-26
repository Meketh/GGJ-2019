using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public float velocidadRotacion = 100;
  public float velocidadTraslacion = 10;
  public Animator anim;
  void Start() {
    anim = GetComponent<Animator>();
  }
  void Update() {
    anim.SetBool("Walk", false);
    anim.SetBool("Idle", true);
    if (Input.GetKey(KeyCode.D)) {
      transform.Rotate(0, velocidadRotacion * Time.deltaTime, 0);
      anim.SetBool("Walk", true);
      anim.SetBool("Idle", false);
    }
    if (Input.GetKey(KeyCode.A)) {
      transform.Rotate(0, -velocidadRotacion * Time.deltaTime, 0);
      anim.SetBool("Walk", true);
      anim.SetBool("Idle", false);
    }
    if (Input.GetKey(KeyCode.W)) {
      transform.Translate(0, 0, velocidadTraslacion * Time.deltaTime);
      anim.SetBool("Walk", true);
      anim.SetBool("Idle", false);
    }
    if (Input.GetKey(KeyCode.S)) {
      transform.Translate(0, 0, -velocidadTraslacion * Time.deltaTime);
      anim.SetBool("Walk", true);
      anim.SetBool("Idle", false);
    }
  }
}
