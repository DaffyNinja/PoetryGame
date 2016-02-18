using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TESTPoetry : MonoBehaviour
{

    public Text text1;

    public Text text2;

    [TextArea]
    public string[] T1;

    [TextArea]
    public string[] T2;


    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < T1.Length && i < T2.Length; i++)
        {
            text1.text = T1[0];

            text2.text = T2[0];
        }
        //

    }

    // Update is called once per frame
    void Update()
    {

    }
}
