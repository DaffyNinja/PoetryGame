using UnityEngine;
using System.Collections;

public class LeverTwo : MonoBehaviour
{
    public GameObject affectedObj1;

   // public float obj1PosX;
   // public float obj1PosY;

    public float zRot1;
    [Space(5)]
    public GameObject affectedObj2;

    //public float obj2PosX;
   // public float obj2PosY;

    public float zRot2;

    public bool activated;

    bool canSwitch;

    Quaternion objStartingRot1;
    Vector2 objStartingPos1;

    Quaternion objStartingRot2;
    Vector2 objStartingPos2;

    // Use this for initialization
    void Start()
    {
        objStartingPos1 = affectedObj1.transform.position;
        objStartingRot1 = affectedObj1.transform.localRotation;

        objStartingPos2 = affectedObj2.transform.position;
        objStartingRot2 = affectedObj2.transform.localRotation;

    }

    // Update is called once per frame
    void Update()
    {
        if (canSwitch)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                print("Lever");
                activated = !activated;
            }
        }

        if (activated)
        {
            affectedObj1.transform.localRotation = Quaternion.Euler(0, 0, zRot1);
           // affectedObj1.transform.position = new Vector2(obj1PosX, obj1PosY);

            affectedObj2.transform.rotation = Quaternion.Euler(0, 0, zRot2);
           // affectedObj2.transform.position = new Vector2(obj2PosX, obj2PosY);
        }
        else
        {
            affectedObj1.transform.rotation = objStartingRot1;
           // affectedObj1.transform.position = objStartingPos1;

            affectedObj2.transform.rotation = objStartingRot2;
           // affectedObj2.transform.position = objStartingPos2;
        }

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            // print("Lever");

            canSwitch = true;

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            // print("Leave");
            canSwitch = false;
        }

    }
}