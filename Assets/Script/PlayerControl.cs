using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float walkSpeed;
    public bool grounded;
    public float jumpForce = 750f;

    private Rigidbody2D rbd;
    private Animator anim;

    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(x));
        anim.SetBool("Grounded", grounded);
        if( x > 0)
        {
            transform.localScale = Vector2.one;
        }
        else if (x < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        rbd.velocity = new Vector2(x * walkSpeed, rbd.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public float Jump()
    {
        if(grounded)
        {
            rbd.AddForce(Vector2.up * jumpForce);
           
        }
        return jumpForce;

    }
    
}
