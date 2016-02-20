using UnityEngine;
using System.Collections;

public class FriendGameMaster : MonoBehaviour {


    public NewPlayerMove playerMove;
    public FriendMove friendMove;

    public bool playerSwitched;

	// Use this for initialization
	void Start ()
    {
        friendMove.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerSwitched = !playerSwitched;
          
        }

        if (playerSwitched)
        {
            playerMove.enabled = false;
            friendMove.enabled = true;
        }
        else if (!playerSwitched)
        {
            playerMove.enabled = true;
            friendMove.enabled = false;

        }


	
	}
}
