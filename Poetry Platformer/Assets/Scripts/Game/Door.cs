using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
   public bool canOpen;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canOpen)
        {
            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                print("Door");
            }
        }


    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //print("Stay");
            canOpen = true;
        }
       

    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           // print("Leave");
            canOpen = false;
        }

    }
}
