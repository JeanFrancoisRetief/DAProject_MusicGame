using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTiggerScript : MonoBehaviour
{
    public CombatScript combatScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyMelee")
        {
            
            combatScript.playerHealth -= combatScript.enemyMeleeDamage;
            Vector3 direction = transform.position - other.transform.position;
            Rigidbody rb = gameObject.GetComponentInParent<Rigidbody>();
            rb.AddForce(direction.normalized * combatScript.knockbackMultiplier);
            rb.AddForce(Vector3.up * combatScript.knockbackMultiplier);
        }

        if (other.tag == "EnemyProjectile")
        {
            combatScript.playerHealth -= combatScript.enemyRangedDamage;
            Destroy(other.gameObject);
        }

    }
}
