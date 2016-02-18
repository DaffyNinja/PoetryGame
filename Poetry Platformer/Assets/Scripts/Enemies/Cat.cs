using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour
{

    public float speed;
    public float jumpHeight;
    [Header("RayCast")]
    public float rayLength;
    public LayerMask playerMask;




    Rigidbody2D rig2D;

    // Use this for initialization
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();

        


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveQauntity = new Vector2(-speed, 0);
        rig2D.velocity = new Vector2(moveQauntity.x, rig2D.velocity.y);


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, rayLength, playerMask);
        Debug.DrawRay(transform.position, Vector2.left, Color.red, rayLength);

        if (hit)
        {
            //print("Ray");

            rig2D.velocity = Vector2.up * jumpHeight;
      
            

            //print(hit.ToString());

        }


    }
}
