using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Enemy Stats")]
    public int Health;

    [Header("Import Player Stats")]
    public CombatScript Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            gameObject.SetActive(false);
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "MeleeAttack")
        {
            Health -= Player.meleeDamage;
        }
        if (other.tag == "RangedAttack" )
        {
            Health -= Player.rangedDamage;
        }
    }
}
