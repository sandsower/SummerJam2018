using System.Collections;
using System.Collections.Generic;
using DoodleStudio95;
using UnityEngine;

public class Player : MonoBehaviour
{
  public float speed = 10;
  private Rigidbody rb;
  public DoodleAnimationFile idle;
  public DoodleAnimationFile moving;

  DoodleAnimator animator;

  // Use this for initialization
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    animator = GetComponent<DoodleAnimator>();
  }

  // Update is called once per frame
  void Update()
  {

  }

  /// <summary>
  /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
  /// </summary>
  void FixedUpdate()
  {
    float x = Input.GetAxis("Horizontal");
    float z = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(x, 0.0f, z);

    Debug.Log(movement);

    var anim = (x == 0 && z == 0) ? idle : moving;
    if (animator.File != anim)
    {
      animator.ChangeAnimation(anim);
    }
    transform.Translate(movement * Time.deltaTime);
  }

}
