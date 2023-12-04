using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//HCS
public class playerMovement : MonoBehaviour
{

    Rigidbody RB;
    
    // Start is called before the first frame update
    void Start()
    {

        RB = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 1, 0);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
                RB.AddForce(new Vector3(-10, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
                RB.AddForce(new Vector3(-5, 0, 0));
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            RB.AddForce(new Vector3(10, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(new Vector3(5, 0, 0));
        }

    }

}
