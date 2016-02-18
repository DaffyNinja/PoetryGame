using UnityEngine;
using System.Collections;

//v0.5.1

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;
    public float jumpSpeed;
    public float jumpCheckDistance;
    public bool isGrounded;
    public bool isSprinting;
    public bool canUseController;

    bool isFacingRight = true;
    float flipMove;

    [Header("Layers")]
    public LayerMask groundLayer;

    [Header("Game Variables")]
    public Vector2 checkPointPos;

    Rigidbody2D rig2D;

    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //print("Test");

        //Movement
        Move();

        //Flip
        if (flipMove > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (flipMove < 0 && isFacingRight)
        {
            Flip();
        }

        Jump();


    }

    void Move()
    {
        //KeyBoard
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rig2D.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rig2D.velocity.y);

            flipMove = 1;

            Flip();


        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rig2D.velocity = new Vector2(-Input.GetAxis("Horizontal") * -moveSpeed, rig2D.velocity.y);

            flipMove = -1;

            Flip();
        }

        // TO BE WORKED ON
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
            if (isSprinting)
            {
                moveSpeed *= 2;
            }
        }
        else
        {
            isSprinting = false;
            moveSpeed = 7.5f;
        }

        //Controller
        if (canUseController == true)
        {
            //print("Can use xbox");

            rig2D.velocity = new Vector2(Input.GetAxis("Joystick Left Stick X") * moveSpeed, rig2D.velocity.y);

            if (Input.GetAxis("Joystick Left Stick X") >= 1)
            {
                //print("Right");

                flipMove = 1;

                Flip();
            }
            else if (Input.GetAxis("Joystick Left Stick X") <= -1)
            {
                //print("Left");


                flipMove = -1;

                Flip();

            }

        }

    }

    void Jump()
    {
        isGrounded = Physics2D.OverlapCircle(gameObject.transform.position, jumpCheckDistance, groundLayer);

        // Jump  Keyboard
        if (Input.GetKey(KeyCode.Space) && isGrounded == true)
        {
            rig2D.AddForce(new Vector2(0f, jumpSpeed));
        }

        //Jump  Controller
        if (Input.GetButtonDown("Fire1") && isGrounded == true)
        {
            rig2D.AddForce(new Vector2(0f, jumpSpeed));
        }


    }

    //Flip Character
    void Flip()
    {
        isFacingRight = !isFacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }
}