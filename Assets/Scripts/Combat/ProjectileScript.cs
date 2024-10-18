using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    //[Header("Main CombatScript (On player)")]
    //public CombatScript combatScript;
    //[Header("Main EnemyScript (On enemy scriptholder)")]
    //public EnemyScript enemyScript;
    [Header("Main EnemyMovmentScript (On enemy)")]
    public EnemyMovement EnemyMovmentScript;
    [Header("Bullets")]
    public float timer = 5;
    private float bulletTime;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    public float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyMovmentScript.distance < 14)
        {
            ShootAtPlayer();
        }
        
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bullet = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation) as GameObject;
        Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletRB.transform.forward * enemySpeed);
        Destroy(bullet, 5f);
    }
}
