using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterQuestHandler : MonoBehaviour
{
    //USE THESE TO CHECK if(questCompleted == true)
    [Header("Main Quest Scripts")]
    public MainQuest001 mainQuest001;
    public MainQuest002 mainQuest002;
    public MainQuest003 mainQuest003;
    public MainQuest004 mainQuest004;
    public MainQuest005 mainQuest005;

    [Header("Side Quest Scripts")]
    public SideQuest001 sideQuest001;
    public SideQuest002 sideQuest002;
    public SideQuest003 sideQuest003;
    public SideQuest004 sideQuest004;
    public SideQuest005 sideQuest005;

    [Header("Main Quest StartTriggers")]
    public GameObject MQ2StartTrigger;
    public GameObject MQ3StartTrigger;
    public GameObject MQ4StartTrigger;
    public GameObject MQ5StartTrigger;

    [Header("Side Quest StartTriggers")]
    public GameObject SQ1StartTrigger;
    public GameObject SQ2StartTrigger;
    public GameObject SQ3StartTrigger;
    public GameObject SQ4StartTrigger;
    public GameObject SQ5StartTrigger;


    [Header("Collectable Scripts")]
    public Collectables001 collectables001;

    [Header("Cutscene Handler")]
    public GameObject CutscenePanel;

    // Start is called before the first frame update
    void Start()
    {
        //OnMenuStartGameClick(); //Debug
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMenuStartGameClick() //start of game -- start of Quest 1
    {
        CutscenePanel.SetActive(true);
        mainQuest001.Cutscene1Video.SetActive(true);
        Invoke(nameof(DeactivateVideos), 6);
    }

    public void DeactivateVideos()
    {
        mainQuest001.Cutscene1Video.SetActive(false);
        mainQuest001.Cutscene2Video.SetActive(false);
        //add more as we go

        CutscenePanel.SetActive(false);
    }

    public void ActivateSideQuestStartTriggers()
    {
        SQ1StartTrigger.SetActive(true);
        SQ2StartTrigger.SetActive(true);
        SQ3StartTrigger.SetActive(true);
        SQ4StartTrigger.SetActive(true);
        SQ5StartTrigger.SetActive(true);
    }
    public void DeactivateSideQuestStartTriggers()
    {
        SQ1StartTrigger.SetActive(false);
        SQ2StartTrigger.SetActive(false);
        SQ3StartTrigger.SetActive(false);
        SQ4StartTrigger.SetActive(false);
        SQ5StartTrigger.SetActive(false);
    }
}
