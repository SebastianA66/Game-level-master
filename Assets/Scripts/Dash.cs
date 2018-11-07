using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public bool dash;
    public bool dashOff;
    public float dashDuration = 0.5f;
    public float dashSpeed = 30f;
    public float dashTimer = 0f;
    public float dashCooldown = 1f;
    PlayerController controller;

    private void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("Dash Start");
            dash = true;
        }
        if (dash == true)
        {
            // start dash timer
            dashTimer += Time.deltaTime;            
            // set your speed from 10 to 30
            controller.moveSpeed = dashSpeed;
            //if timer is greater then dashDuration set speed back to normal
            if(dashTimer > dashDuration)
            {
                Debug.Log("Dash Working");
                // dash = false
                dash = false;
                // Set speed to normal
                controller.moveSpeed = controller.startSpeed;                
                // set your timer to 0
                dashTimer = 0f;
                
                dashOff = true;
                // Cooldown start 
                dashCooldown += Time.deltaTime;
                //
            }
           
        }
    }
}
