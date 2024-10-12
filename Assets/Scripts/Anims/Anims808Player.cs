using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anims808Player : MonoBehaviour
{
    public Animator animator808;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        animator808.SetBool("isMelee", false);
        animator808.SetBool("isRanged", false);
        animator808.SetBool("isRunning", false);
        animator808.SetBool("isFlying", false);
        animator808.SetBool("isIdle", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            //Ranged Attack
            animator808.SetBool("isMelee", false);
            animator808.SetBool("isRanged", true);
            animator808.SetBool("isRunning", false);
            animator808.SetBool("isFlying", false);
            animator808.SetBool("isIdle", false);
        }
        else if (Input.GetMouseButton(0))
        {
            //Melee Attack
            animator808.SetBool("isMelee", true);
            animator808.SetBool("isRanged", false);
            animator808.SetBool("isRunning", false);
            animator808.SetBool("isFlying", false);
            animator808.SetBool("isIdle", false);
        }
        else if(playerMovement.inFlight)
        {
            //Flying
            animator808.SetBool("isMelee", false);
            animator808.SetBool("isRanged", false);
            animator808.SetBool("isRunning", false);
            animator808.SetBool("isFlying", true);
            animator808.SetBool("isIdle", false);
        }
        else if(Input.GetKey(KeyCode.LeftShift))
        {
            //Running
            animator808.SetBool("isMelee", false);
            animator808.SetBool("isRanged", false);
            animator808.SetBool("isRunning", true);
            animator808.SetBool("isFlying", false);
            animator808.SetBool("isIdle", false);
        }
        else
        {
            //Idle/Walk
            animator808.SetBool("isMelee", false);
            animator808.SetBool("isRanged", false);
            animator808.SetBool("isRunning", false);
            animator808.SetBool("isFlying", false);
            animator808.SetBool("isIdle", true);
        }
    }
}
