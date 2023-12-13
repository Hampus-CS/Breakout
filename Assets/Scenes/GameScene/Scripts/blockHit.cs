using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HCS
public class blockHit : MonoBehaviour
{

    int hp = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void blockTakeDamage()
    {

        hp -= 1;
            
        if (hp == 0)
        {
            
            Destroy(gameObject);
            
        }

    }

    void OnCollisionEnter(Collision collision)
    {

        GameObject otherGameObject = collision.gameObject;
        ballMovement hitBlock = otherGameObject.GetComponent<ballMovement>();

        if (hitBlock != null)
        {

            hitBlock.winCondition();

        }

    }

}