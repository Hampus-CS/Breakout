using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockCollision : MonoBehaviour
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

        Debug.Log("Träff");

        GameObject otherGameObject = collision.gameObject;
        blockHit hitBlock = otherGameObject.GetComponent<blockHit>();

        if (hitBlock != null)
        {
            hitBlock.TakeDamage();
        }
        
    }

}