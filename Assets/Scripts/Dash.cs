using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public bool dash;
    public bool dashCool;
    public float dashDuration = 0.005f;
    public float dashSpeed = 30f;
    public float dashTimer = 0f;
    public float dashCooldown = 3.1f;
    public float currentCooldown; 
    PlayerController controller;

    public bool onCoolDown = false;

    private void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1) && !onCoolDown)
        {
            Debug.Log("Dash Start");
            dash = true;

            currentCooldown = dashCooldown;
            Debug.Log(currentCooldown.ToString() + " || " + dashCooldown.ToString());
        }

        if (dash == true)
        {
            onCoolDown = true;
            // start dash timer
            dashTimer += Time.deltaTime;
            // set your speed from 10 to 30
            controller.moveSpeed = dashSpeed;
            //if timer is greater then dashDuration set speed back to normal
            if (dashTimer > dashDuration)
            {
                Debug.Log("Dash Working");
                // dash = false
                dash = false;
                // Set speed to normal
                controller.moveSpeed = controller.startSpeed;
                // set your timer to 0
                dashTimer = 0f;
            }
        }

        if (onCoolDown == true)
        {
            currentCooldown -= Time.deltaTime;
            Debug.Log(currentCooldown + " to go");
            if (currentCooldown <= 0)
            {
                onCoolDown = false;
            }
        }
    }
}
