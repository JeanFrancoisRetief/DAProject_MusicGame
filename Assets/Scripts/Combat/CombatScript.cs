using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatScript : MonoBehaviour
{
    [Header("Melee Attack")]
    public GameObject MeleeTriggerObject;
    public bool readyToMelee;
    public int meleeFrameCounter;

    [Header("Ranged Attack")]
    public GameObject RangedTriggerObject;
    public GameObject CrossAir;

    [Header("Ranged Attack Orientation")]
    public Transform CombatLookAt;
    public Transform RangedTriggerOrientation;
    
    // Start is called before the first frame update
    void Start()
    {
        readyToMelee = true;
        meleeFrameCounter = 0;

        MeleeTriggerObject.SetActive(false);
        RangedTriggerObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RangedTriggerOrientation.LookAt(CombatLookAt);

        if(Input.GetMouseButton(1))
        {
            CrossAir.SetActive(true);
        }
        else
        {
            CrossAir.SetActive(false);
        }


        if (Input.GetMouseButton(0) && Input.GetMouseButton(1))
        {
            MeleeTriggerObject.SetActive(false);
            RangedTriggerObject.SetActive(true);
        }
        else if(Input.GetMouseButton(0))
        {
            MeleeTriggerObject.SetActive(true);
            RangedTriggerObject.SetActive(false);
            //readyToMelee = false;
        }
        else
        {
            MeleeTriggerObject.SetActive(false);
            RangedTriggerObject.SetActive(false);
        }

        
    }

    
}
