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
        
    }
}
