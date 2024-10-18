using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimsEnemy : MonoBehaviour
{
    public Animator animatorEnemy;
    public EnemyMovement enemyMovement;
    // Start is called before the first frame update
    void Start()
    {
        animatorEnemy.SetBool("isMelee", false);
        animatorEnemy.SetBool("isRanged", false);
        animatorEnemy.SetBool("isRunning", false);
        animatorEnemy.SetBool("isIdle", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyMovement.distance <= 4)
        {
            animatorEnemy.SetBool("isMelee", true);
            animatorEnemy.SetBool("isRanged", false);
            animatorEnemy.SetBool("isRunning", false);
            animatorEnemy.SetBool("isIdle", false);
        }
        else if (enemyMovement.distance <= 14)
        {
            animatorEnemy.SetBool("isMelee", false);
            animatorEnemy.SetBool("isRanged", true);
            animatorEnemy.SetBool("isRunning", false);
            animatorEnemy.SetBool("isIdle", false);
        }
        else if (enemyMovement.distance <= 25)
        {
            animatorEnemy.SetBool("isMelee", false);
            animatorEnemy.SetBool("isRanged", false);
            animatorEnemy.SetBool("isRunning", true);
            animatorEnemy.SetBool("isIdle", false);
        }
        else
        {
            animatorEnemy.SetBool("isMelee", false);
            animatorEnemy.SetBool("isRanged", false);
            animatorEnemy.SetBool("isRunning", false);
            animatorEnemy.SetBool("isIdle", true);
        }
    }
}
