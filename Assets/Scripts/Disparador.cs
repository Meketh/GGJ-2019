using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {
  public GameObject Bala;
  public float cooldown = 1.5f;
  public float cooldownTimer = 0f;
    public Animator anim;
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }
    void Update() {
    if (cooldownTimer > 0) {
      cooldownTimer -= Time.deltaTime;
            if (Input.GetMouseButtonUp(0))
            {
                anim.SetBool("Ataque", false);
            }
        } else if (cooldownTimer <= 0f && Input.GetMouseButton(0)) {
      cooldownTimer = 0.5f;
      anim.SetBool("Ataque", true);
      Instantiate(Bala, transform.position, transform.rotation);
    }
    }
}
