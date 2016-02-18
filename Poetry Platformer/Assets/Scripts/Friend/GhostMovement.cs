using UnityEngine;
using System.Collections;

public class GhostMovement : MonoBehaviour
{

    public float ghostSpeed;

    public NewPlayerMove playMove;

    public FriendGhost fGhost;

    bool dontMove;

    // Use this for initialization
    void Start()
    {
        playMove = GameObject.FindGameObjectWithTag("Player").GetComponent<NewPlayerMove>();

        fGhost = GameObject.FindGameObjectWithTag("Player").GetComponent<FriendGhost>();

    }

    // Update is called once per frame
    void Update()
    {
        //playMove = GameObject.FindGameObjectWithTag("Player").GetComponent<NewPlayerMove>();


        if (playMove.isFacingRight)
        {
            transform.Translate(-ghostSpeed, 0, 0);


        }
        else
        {
            transform.Translate(ghostSpeed, 0, 0);
        }


        if (fGhost.destroyGhost)
        {
            Destroy(this.gameObject);

        }

    }
}
