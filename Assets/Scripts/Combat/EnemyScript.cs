using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    [Header("Enemy Stats")]
    public int Health;
    public int MaxHealth;

    [Header("Game Objects")]
    public GameObject EnemyParentObject;
    public Slider HealthSlider;
    public GameObject EnemyUICanvas;
    public Transform TargetCam;


    [Header("Import Player Stats")]
    public CombatScript Player;
    // Start is called before the first frame update
    void Start()
    {
        HealthSlider.maxValue = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {
            Player.stateMachineScript.inCombat = false;
            EnemyParentObject.SetActive(false);

        }
        HealthSlider.value = Health;
        EnemyUICanvas.transform.LookAt(TargetCam);

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
