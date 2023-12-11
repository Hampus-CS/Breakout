using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HCS
public class blockHit : MonoBehaviour
{

    [SerializeField]
    private GameObject gameWin;

    // Start is called before the first frame update
    void Start()
    {
        gameWin.active = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    int hp = 1;
    int blockDestroyed = 0;

    public void TakeDamage()
    {

        //hp -= 1;
        blockDestroyed += 1;
        Destroy(gameObject);
        Debug.Log(blockDestroyed);
        if (blockDestroyed==84)
        {

            gameWin.active = true;

        }
        /*if (hp == 0)
        {
            
            Destroy(gameObject);
            
        }
        */

    }
    
}