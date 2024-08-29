using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKate : MonoBehaviour
{
    

    public CombatScript combatScript;
    public PlayerMovement playerMovementScript;

    public GameObject Visuals808;
    public GameObject VisualsKate;
    // Start is called before the first frame update
    void Start()
    {
        combatScript.isKate = false;
        playerMovementScript.isKate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToKate()
    {
        Visuals808.SetActive(false);
        VisualsKate.SetActive(true);

        combatScript.isKate = true;
        playerMovementScript.isKate = true;
    }

    public void SwitchTo808()
    {
        Visuals808.SetActive(true);
        VisualsKate.SetActive(false);

        combatScript.isKate = false;
        playerMovementScript.isKate = false;
    }
}
