using UnityEngine;
using System.Collections;

public class HeadTrig : MonoBehaviour
{

    public float jumpBoost;

    GameObject parentObj;

   // public bool beenHit;

    void Start()
    {
        parentObj = gameObject.transform.parent.gameObject;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            col.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpBoost;

            print("Trig");

            Destroy(parentObj);
            Destroy(gameObject);

           // beenHit = true;

        }

    }
}

