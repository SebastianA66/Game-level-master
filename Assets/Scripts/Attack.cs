using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool attack;
    public float attackDur = 0.3f;
    

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack = true;
        }

        
    }

}
