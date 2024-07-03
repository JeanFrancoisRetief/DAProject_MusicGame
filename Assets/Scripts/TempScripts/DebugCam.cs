using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCam : MonoBehaviour
{

    public GameObject ExpCam;
    public GameObject ComCam;

    public GameObject ExpText;
    public GameObject ComText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ExpCam.active == true)
        {
            ExpText.SetActive(true);
        }
        else
        {
            ExpText.SetActive(false);
        }

        if (ComCam.active == true)
        {
            ComText.SetActive(true);
        }
        else
        {
            ComText.SetActive(false);
        }
    }

}
