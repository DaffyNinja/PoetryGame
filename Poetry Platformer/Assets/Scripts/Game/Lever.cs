using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{

    public GameObject affectedObj;
    public float zAngle;
    //[Space(5)]
    //public float posX;
    //public float posY;

    public bool activated;

    Transform leverHandle;
    public float handleRot;
    Quaternion handleStartingRot;

    bool canSwitch;

    Quaternion objStartingRot;
    Vector2 objStartingPos;

    // Use this for initialization
    void Start()
    {
        objStartingPos = affectedObj.transform.position;

        objStartingRot = affectedObj.transform.localRotation;

        leverHandle = gameObject.transform.GetChild(0);
        handleStartingRot = leverHandle.rotation;





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
            affectedObj.transform.localRotation = Quaternion.Euler(0, 0, zAngle);
            leverHandle.transform.localRotation = Quaternion.Euler(0, 0, handleRot);

            // affectedObj.transform.position = new Vector2(posX, posY);
        }
        else
        {
            affectedObj.transform.localRotation = objStartingRot;
            leverHandle.transform.localRotation = handleStartingRot;

            //affectedObj.transform.position = objStartingPos;
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
