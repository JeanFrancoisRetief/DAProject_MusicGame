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

    [Header("Quest UI")]
    public Text QuestTitleText;
    public Text QuestObjectiveText;
    public Text TutorialText;

    [Header("Dialogue UI")]
    public GameObject DialoguePanel;
    public Text DialogueSpeakerText;
    public Text SubtitlesText;

    [Header("Win Screen")]
    public GameObject WinPanel;

    [Header("Defeat Screen")]
    public GameObject LosePanel;

    [Header("Music Screen")]
    public GameObject MusicCanvas;

    [Header("Menu Screen")]
    public GameObject MenuCanvas;

    [Header("HUD Screen")]
    public GameObject UICanvas;



    // Start is called before the first frame update
    void Start()
    {
        FlightSlider.maxValue = playerMovementScript.flightMaxTime*60;
        HealthSlider.maxValue = combatScript.playerMaxHealth; ;

        DialoguePanel.SetActive(false);
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
            //LosePanel.SetActive(false);
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

        if (WinPanel.active == true || LosePanel.active == true || MusicCanvas.active == true || MenuCanvas.active == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (MenuCanvas.active == true)
        {
            UICanvas.SetActive(false);
        }
        else
        {
            UICanvas.SetActive(true);
        }

    }

    public void OnVictoryScreenExitClick()
    {
        

        WinPanel.SetActive(false);
    }

}
