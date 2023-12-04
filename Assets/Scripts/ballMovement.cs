using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HCS
public class ballMovement : MonoBehaviour
{

    Rigidbody RB;
    int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        
        RB = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 4, 0);
        RB.AddForce(new Vector3(0, -0.1f, 0));

    }

    // Update is called once per frame
    void Update()
    {
        
        float speed = 4;
        RB.velocity = RB.velocity.normalized * speed;

    }
    
    public void TakeDamage()
    {

        hp -= 1;
        transform.position = new Vector3(0, 4, 0);
        RB.AddForce(new Vector3(0, -0.3f, 0));
        

        if (hp == 0)
        {

            Destroy(gameObject);
            //Game Over

        }

    }

}
