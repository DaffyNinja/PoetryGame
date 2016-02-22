using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour
{
    public bool inLadder;

    public NewPlayerMove newPlayMov;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        

        if (col.gameObject.tag == "Player")
        {
            newPlayMov = col.gameObject.GetComponent<NewPlayerMove>();

            newPlayMov.canMoveLadder = true;

           // print("Entered");

            inLadder = true;

        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //print("Exit");

           // newPlayMov = col.gameObject.GetComponent<NewPlayerMove>();

            newPlayMov.canMoveLadder = false;

            inLadder = false;

        }
    }

}
