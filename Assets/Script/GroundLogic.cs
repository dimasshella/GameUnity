using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLogic : MonoBehaviour
{
    private PlayerControl pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponentInParent<PlayerControl>();
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            pc.grounded = true;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            pc.grounded = true;
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            pc.grounded = false;
        }
    }
    void Update()
    {
        
    }
}
