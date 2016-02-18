using UnityEngine;
using System.Collections;

public class RevealPoem : MonoBehaviour {

    public float newSize;

    public float zoomSpeed;

    public float movementSpeed;

    public float rotationSpeed;

    public float distanceBack;

    public bool startReveal;

    [Space(10)]

    public Transform centerPos;


    Camera mainCam;



	// Use this for initialization
	void Start () 
    {
        mainCam = GetComponent<Camera>();
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (startReveal)
        {
            mainCam.orthographicSize = Mathf.Lerp(mainCam.orthographicSize, newSize, zoomSpeed);

            mainCam.gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);

            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, centerPos.transform.position,movementSpeed);

          //  gameObject.transform.position = new -20f;


        }

	
	}
}
