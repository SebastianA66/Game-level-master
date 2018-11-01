using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHandler : MonoBehaviour
{
    public bool alive;
    public float maxHealth;
    public float curHealth;
    public GUIStyle healthBar;

    private void Start()
    {
        curHealth = maxHealth;
        alive = true;
        
    }

    private void LateUpdate()
    {
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if(curHealth <= 0 || !alive)
        {
            curHealth = 0;
        }
        if (alive && curHealth == 0)
        {
            alive = false;
            
        }
    }
}
