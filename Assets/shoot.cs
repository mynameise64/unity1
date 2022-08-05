using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float range = 5;


    private void Update() {
        Vector3 direction = Vector3.forward;
      if (Input.GetMouseButtonDown(1)) {
            
      } 
      Ray ray = new Ray(transform.position,transform.TransformDirection(direction*range));
      Debug.DrawRay(transform.position,transform.TransformDirection(direction*range));
      if (Physics.Raycast(ray, out RaycastHit hit, range)) {
        if (hit.collider.tag == "enemy") {
            hit.collider.gameObject.transform.position = new(0,0,0);
        }
      }
    }
}
