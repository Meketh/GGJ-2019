using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public GameObject Bala;
  public float speed = 30f;
  float cooldown = 1.5f;
  float cooldownTimer = 0f;
  Vector3 cameraOffset = 30 * new Vector3(0, 2, -1);

  Animator anim;
  void Start() {
    anim = GetComponent<Animator>();
  }
  void Update() {
    var translation = new Vector3();
    var displacement = speed * Time.deltaTime;
    if (Input.GetKey(KeyCode.W)) {
      translation += displacement * Vector3.forward;
    }
    if (Input.GetKey(KeyCode.A)) {
      translation += displacement * Vector3.left;
    }
    if (Input.GetKey(KeyCode.S)) {
      translation += displacement * Vector3.back;
    }
    if (Input.GetKey(KeyCode.D)) {
      translation += displacement * Vector3.right;
    }
    transform.position += translation;
    anim.SetBool("Walk", translation != Vector3.zero);
    anim.SetBool("Idle", translation == Vector3.zero);
    if (cooldownTimer > 0) {
      cooldownTimer -= Time.deltaTime;
      if (Input.GetMouseButtonUp(0)) {
        anim.SetBool("Attack", false);
      }
    } else if (cooldownTimer <= 0f && Input.GetKey(KeyCode.Space)) {
      cooldownTimer = 0.5f;
      anim.SetBool("Attack", true);
      Instantiate(Bala, transform);
    }
    float distance;
    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    var plane = new Plane(Vector3.up, transform.position);
    if (plane.Raycast(ray, out distance)) {
      transform.LookAt(ray.GetPoint(distance));
    }
    Camera.main.transform.position = transform.position + cameraOffset;
    Camera.main.transform.LookAt(transform.position);
  }
}
