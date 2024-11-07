using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimsNPCKate : MonoBehaviour
{
    public Animator animatorKateNPC;
    public KateMovement kateMovement;
    // Start is called before the first frame update
    void Start()
    {
        animatorKateNPC.SetBool("isIdle", true);
        animatorKateNPC.SetBool("isRunning", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(kateMovement.distance < 20 && !kateMovement.isAtEnd)
        {
            animatorKateNPC.SetBool("isIdle", false);
            animatorKateNPC.SetBool("isRunning", true);
        }
        else
        {
            animatorKateNPC.SetBool("isIdle", true);
            animatorKateNPC.SetBool("isRunning", false);
        }
    }
}
