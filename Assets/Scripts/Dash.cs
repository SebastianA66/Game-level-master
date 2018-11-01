using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public bool dash;
    public float dashDuration = 0.5f;
    public float dashSpeed = 30f;
    
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            dash = true;
        }
        if (dash == true)
        {
            // start dash timer

            // set your speed from 10 to 30
            dashSpeed = 
            //if timer is greater then dashDuration set speed back to normal
            if(Time.deltaTime > dashDuration)
            {
                // dash = false
                dash = false;
                // set your timer to 0
                Time.fixedDeltaTime = 0f;
            }
           
        }
    }
}
