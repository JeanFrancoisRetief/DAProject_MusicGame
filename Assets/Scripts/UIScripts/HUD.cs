using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [Header("Flight Guage")]
    public Slider FlightSlider;
    public PlayerMovement playerMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        FlightSlider.maxValue = playerMovementScript.flightMaxTime*60;
    }

    // Update is called once per frame
    void Update()
    {
        FlightSlider.value = playerMovementScript.flightTimer;
    }
}
