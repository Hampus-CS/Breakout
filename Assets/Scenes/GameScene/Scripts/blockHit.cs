using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HCS
public class blockHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    int hp = 1;

    public void TakeDamage()
    {

        hp -= 1;
        if (hp == 0)
        {
            
            Destroy(gameObject);
            
        }

    }
    
}