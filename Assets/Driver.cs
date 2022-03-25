using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 200f; //serailize this variable. This attribute will make them IDE editable;
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //steerAmount depends from steerSpeed (higher spped means higher turn rate) and deltaTime. 
        //deltaTime (time per frame) makes steerAmount framerate independand (it goes up for slower CPU and in oposite direction for fast CPU's)
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime; //get user input from input manager; in this case left/right arrow press
        float moveAmount = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
        
        
        
    }
}
