using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HCS
public class floorCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter(Collision collision)
    {

        GameObject otherGameObject = collision.gameObject;
        ballMovement hitFloor = otherGameObject.GetComponent<ballMovement>();

        if (hitFloor != null)
        {
            
            hitFloor.TakeDamage();
        
        }

    }
    
}
