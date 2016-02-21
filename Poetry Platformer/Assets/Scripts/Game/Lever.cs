using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{
    public bool activated;
    public GameObject affectedObj;
    [Space(5)]
    public float posX;
    public float posY;


    bool canSwitch;

    Quaternion objStartingRot;
    Vector2 objStartingPos;

    // Use this for initialization
    void Start()
    {
        objStartingPos = affectedObj.transform.position;

        objStartingRot = affectedObj.transform.localRotation;
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
            affectedObj.transform.rotation = new Quaternion(0, 0, 0, 0);

            affectedObj.transform.position = new Vector2(5, -1f);
        }
        else
        {
            affectedObj.transform.rotation = objStartingRot;

            affectedObj.transform.position = objStartingPos;
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
