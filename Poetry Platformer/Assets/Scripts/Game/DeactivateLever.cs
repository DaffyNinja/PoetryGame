using UnityEngine;
using System.Collections;

public class DeactivateLever : MonoBehaviour
{

    public GameObject leverObj;
    Lever objLeverCom;

    Lever thisLeverCom;





    // Use this for initialization
    void Start()
    {
        objLeverCom = leverObj.GetComponent<Lever>();
        thisLeverCom = GetComponent<Lever>();

    }

    // Update is called once per frame
    void Update()
    {

        if (thisLeverCom.activated)
        {
            objLeverCom.activated = !objLeverCom.activated;
        }

    }
}
