using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{

    //public bool canSwitch;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (canSwitch)
        //{
        //    if (Input.GetKeyDown(KeyCode.LeftShift))
        //    {
        //        print("Lever");


        //    }

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("Lever");


        }
    }

}
