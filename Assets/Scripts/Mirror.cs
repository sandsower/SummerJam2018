using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
  Collider reflectionCollider;

  // Use this for initialization
  void Start()
  {
    reflectionCollider = transform.GetComponent<Collider>();
  }

  // Update is called once per frame
  void Update()
  {
    // RaycastHit hit;
    // Ray reflectionRay = new Ray(transform.position, Vector3.back);

    // Debug.DrawRay(transform.position, Vector3.back, Color.magenta, 200);

    // if (Physics.Raycast(reflectionRay, out hit, reflectionDistance))
    // {
    //   if (hit.collider.tag == "Player")
    //   {
    //     Debug.Log("Hit!");
    //   }
    // }
  }

  /// <summary>
  /// OnTriggerStay is called once per frame for every Collider other
  /// that is touching the trigger.
  /// </summary>
  /// <param name="other">The other Collider involved in this collision.</param>
  void OnTriggerStay(Collider other)
  {
    if (other.tag == "Player")
    {
      Debug.Log("Hit!");
    }
  }
}
