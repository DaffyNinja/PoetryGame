using UnityEngine;
using System.Collections;

public class FriendGhost : MonoBehaviour
{

    public GameObject ghostObj;

    public float ghostLifeTime;
    float timer;

    public bool canMakeGhost;
    public bool destroyGhost;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canMakeGhost)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Instantiate(ghostObj, transform.position, Quaternion.identity);

                canMakeGhost = false;

                destroyGhost = false;
            }
        }
        else
        {
            timer += Time.deltaTime;

            if (timer >= ghostLifeTime)
            {
                destroyGhost = true;

                canMakeGhost = true;

                

                timer = 0;
            }
        }

        //ghostObj.transform.Translate(ghostSpeed, 0, 0);

    }
}
