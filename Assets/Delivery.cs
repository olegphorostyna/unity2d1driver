using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float packageDestroyDealy=0.2f;

 //Triggered when this object intract with the game object with active collider  
 public void OnCollisionEnter2D(Collision2D other)
 {
     Debug.Log("Ouch...");
 }

 //Triggered when this object intract with the game object with active collider as the trigger
 // Is triger option is turned on
 public void OnTriggerEnter2D(Collider2D other) {
     if(other.tag == "Package" && !hasPackage){  // you can set tag for game object in the IDE
        Debug.Log("Package picked up");
        hasPackage = true;
        Destroy(other.gameObject, packageDestroyDealy); // completely remove game object after some delay time
     }

      if(other.tag == "Customer" && hasPackage){
        Debug.Log("Package delivered");
        hasPackage = false;
     }
 }
}
