using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  

    //this will create reference to game object in IDE. We can set refered to object there, to
    //make it avaliable in our code;
    [SerializeField] GameObject thingToFollow;
    //this object position (camera) shoud be the same as the car's position
    void LateUpdate() // called afer all physics and user input is processed
    {
      transform.position = thingToFollow.transform.position + new Vector3(0,0,-10); 
    }
}
