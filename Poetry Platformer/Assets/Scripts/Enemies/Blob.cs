using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Blob : MonoBehaviour
{

    public float speed;            

    public bool moveRight;
    public bool moveLeft;

    public float rayLength;
    public LayerMask hitLayer;

    Rigidbody2D rig2D;



    // Use this for initialization
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    void Movement()
    {

        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, Vector2.left, rayLength, hitLayer);
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, Vector2.right, rayLength, hitLayer);

        Debug.DrawRay(transform.position, Vector2.left, Color.red, rayLength);
        Debug.DrawRay(transform.position, Vector2.right, Color.red, rayLength);

        if (hitLeft)
        {
            moveLeft = false;
            moveRight = true;
        }
        else if (hitRight)
        {
            moveLeft = true; 
            moveRight = false;
        }

        if (moveLeft)
        {
            Vector2 moveQauntity = new Vector2(-speed, 0);
            rig2D.velocity = new Vector2(moveQauntity.x, rig2D.velocity.y);
        }
        else if (moveRight)
        {
            Vector2 moveQauntity = new Vector2(speed, 0);
            rig2D.velocity = new Vector2(moveQauntity.x, rig2D.velocity.y);

        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Player")
        {



            print("Hit");


        }

    }
}
