using UnityEngine;
using System.Collections;

//RequireComponents
[RequireComponent( typeof(Rigidbody) )]

public class scrPlayer : MonoBehaviour
{

    //MyVars
    [SerializeField]private float speed,maxSpeed,jmpSpeed,smoothLook;
    [SerializeField]private bool isGrounded = false;
    //My Comps
    private Rigidbody rb;

    void Awake()
    {
        //Load Comps
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();


    }

    void Movement()
    {
        //Walk
        if (scrControls.vertical() != 0 || scrControls.horizontal() != 0)
        {
            if (rb.velocity.magnitude <= maxSpeed)
            {
                rb.velocity = speed/2 *((scrControls.vertical() * transform.forward) + (scrControls.horizontal() * transform.right));
            }
        }


        //Rotation
        float targetRot = Camera.main.transform.eulerAngles.y;
        transform.eulerAngles = new Vector3(0,Mathf.LerpAngle(transform.eulerAngles.y,targetRot,smoothLook),0);

        //Jump
        if ( Physics.Raycast(transform.position,Vector3.down,1.2f) )
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }


    }
}
