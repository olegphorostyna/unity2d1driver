using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
  
 public void OnCollisionEnter2D(Collision2D other)
 {
     Debug.Log("Ouch...");
 }

 public void OnTriggerEnter2D(Collider2D other) {
     Debug.Log("trigerred...");
 }
}
