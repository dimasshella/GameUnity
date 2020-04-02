using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int kekuatanJump, moveSpeed;
    public bool back;
    public int move;
    Rigidbody2D jump;

    public bool tanah;
    public LayerMask targetLayar;
    public Transform deteksitanah;
    public float jangkauan;

    void Start()
    {
        jump = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        tanah = Physics2D.OverlapCircle (deteksitanah.position, jangkauan, targetLayar);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            move = -1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
            move = 1;
        }

        if (tanah == true &&(Input.GetKey(KeyCode.Mouse0)))
        {
            jump.AddForce(new Vector2(0, kekuatanJump));
        }

        if (move > 0 && !back)
        {
            backMove();
        }
        else if (move <0 && back)
        {
            backMove();
        }
    }

    void backMove()
    {
        back = !back;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;

    }
        

    
}
