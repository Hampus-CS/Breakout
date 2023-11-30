using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{

    Rigidbody RB;
    
    // Start is called before the first frame update
    void Start()
    {
        
        RB = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 3, 0);
        RB.AddForce(new Vector3(0, -0.5f, 0));

    }

    // Update is called once per frame
    void Update()
    {
        
        float speed = 4;
        RB.velocity = RB.velocity.normalized * speed;
    
    }

}
