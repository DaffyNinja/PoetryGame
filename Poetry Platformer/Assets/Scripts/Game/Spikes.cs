using UnityEngine;
using System.Collections;


public class Spikes : MonoBehaviour {

    public bool canMove;

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        // Make move up and down
        if (canMove)
        {
            gameObject.transform.Translate(0, speed, 0);
        }
	
	}

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "Player")
    //    {
    //        //print("HIT!");

    //        col.transform.position = col.GetComponent<PlayerMove>().checkPointPos;

    //        //Application.LoadLevel(Application.loadedLevel);
    //    }
    //}
}
