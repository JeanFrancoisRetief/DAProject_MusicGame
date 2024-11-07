using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimsPlayableKate : MonoBehaviour
{
    public Animator animatorKatePlayable;
    public PlayerMovement playerMovement;

    private bool isMoving;
    // Start is called before the first frame update
    void Start()
    {
        isMoving = false;
        animatorKatePlayable.SetBool("isIdle", true);
        animatorKatePlayable.SetBool("isWalking", false);
        animatorKatePlayable.SetBool("isRunning", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }



        if (Input.GetKey(KeyCode.LeftShift) && isMoving)
        {
            animatorKatePlayable.SetBool("isIdle", false);
            animatorKatePlayable.SetBool("isWalking", false);
            animatorKatePlayable.SetBool("isRunning", true);
        }
        else if (isMoving)
        {
            animatorKatePlayable.SetBool("isIdle", false);
            animatorKatePlayable.SetBool("isWalking", true);
            animatorKatePlayable.SetBool("isRunning", false);
        }
        else
        {
            animatorKatePlayable.SetBool("isIdle", true);
            animatorKatePlayable.SetBool("isWalking", false);
            animatorKatePlayable.SetBool("isRunning", false);
        }
    }
}
