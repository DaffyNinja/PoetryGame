using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Blob : MonoBehaviour
{

    public float speed;

    Rigidbody2D rig2D;

    //HeadTrig hTrig;


    // Use this for initialization
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();

        //hTrig = GetComponentInChildren<HeadTrig>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveQauntity = new Vector2(-speed, 0);
        rig2D.velocity = new Vector2(moveQauntity.x, rig2D.velocity.y);

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //if (!hTrig.beenHit)
       // {
            if (col.gameObject.tag == "Player")
            {

                print("Hit");

                //    EditorSceneManager.LoadScene(EditorSceneManager.loadedSceneCount);
            }
        //}
    }
}
