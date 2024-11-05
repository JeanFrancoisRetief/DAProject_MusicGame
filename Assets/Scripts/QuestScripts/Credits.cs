using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public bool isCreditsRolling;
    public bool isCreditsDone;

    public GameObject CreditsText;
    public GameObject CreditsBackDrop;

    public int framecount;

    [SerializeField]
    public int seconds;

    void Start()
    {
        framecount = 0;
        seconds = 0;

        isCreditsDone = false;
        isCreditsRolling = false;

    }
    private void Update()
    {
        if(isCreditsRolling == true)
        {
            CreditsBackDrop.SetActive(true);
            CreditsText.transform.Translate(Vector3.up);

            framecount++;
            if (framecount >= 60)
            {
                seconds++;
                framecount = 0;
            }

            if (seconds >= 60)
            {
                //Debug.Log("Exit Program");
                //SceneManager.LoadScene("Main Menu");
                isCreditsRolling = false;
                isCreditsDone = true;
            }
        }
        else
        {
            CreditsBackDrop.SetActive(false);
        }    

        if(isCreditsDone)
        {
            CreditsBackDrop.transform.position = new Vector3(CreditsBackDrop.transform.position.x, CreditsBackDrop.transform.position.y, 100000);
            CreditsBackDrop.SetActive(false);
        }


        

    }
}
