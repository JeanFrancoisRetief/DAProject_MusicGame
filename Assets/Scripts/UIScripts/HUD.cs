using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("Flight Guage")]
    public Slider FlightSlider;
    public PlayerMovement playerMovementScript;

    [Header("Health Guage")]
    public Slider HealthSlider;
    public CombatScript combatScript;

    [Header("Win Screen")]
    public GameObject WinPanel;

    [Header("Defeat Screen")]
    public GameObject LosePanel;
    // Start is called before the first frame update
    void Start()
    {
        FlightSlider.maxValue = playerMovementScript.flightMaxTime*60;
        HealthSlider.maxValue = combatScript.playerMaxHealth; ;
    }

    // Update is called once per frame
    void Update()
    {
        if (combatScript.playerHealth <= 0)
        {
            //combatScript.playerHealth = 0;
            LosePanel.SetActive(true);
        }
        else
        {
            LosePanel.SetActive(false);
        }

        FlightSlider.value = playerMovementScript.flightTimer;
        HealthSlider.value = combatScript.playerHealth;
        if (HealthSlider.value != HealthSlider.maxValue)
        {
            HealthSlider.gameObject.SetActive(true);
        }
        else
        {
            HealthSlider.gameObject.SetActive(false);
        }

        if (FlightSlider.value != FlightSlider.maxValue)
        {
            FlightSlider.gameObject.SetActive(true);
            HealthSlider.gameObject.SetActive(true);
        }
        else
        {
            FlightSlider.gameObject.SetActive(false);
            //HealthSlider.gameObject.SetActive(false);
        }

    }

    public void OnVictoryScreenExitClick()
    {
        

        WinPanel.SetActive(false);
    }
}
