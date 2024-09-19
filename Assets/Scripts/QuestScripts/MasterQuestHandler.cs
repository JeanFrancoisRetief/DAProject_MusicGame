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

    [Header("Quest Done Bools")]
    public bool MQ1Done;
    public bool MQ2Done;
    public bool MQ3Done;
    public bool MQ4Done;
    public bool MQ5Done;
    public bool SQ1Done;
    public bool SQ2Done;
    public bool SQ3Done;
    public bool SQ4Done;
    public bool SQ5Done;



    // Start is called before the first frame update
    void Start()
    {
        //OnMenuStartGameClick(); //Debug
        MQ1Done = false;
        MQ2Done = false;
        MQ3Done = false;
        MQ4Done = false;
        MQ5Done = false;

        SQ1Done = false;
        SQ2Done = false;
        SQ3Done = false;
        SQ4Done = false;
        SQ5Done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(mainQuest001.ThisQuest.active == true|| mainQuest002.ThisQuest.active == true || mainQuest003.ThisQuest.active == true 
            || mainQuest004.ThisQuest.active == true || mainQuest005.ThisQuest.active == true ||
            sideQuest001.ThisQuest.active == true || sideQuest002.ThisQuest.active == true || sideQuest003.ThisQuest.active == true
            || sideQuest004.ThisQuest.active == true || sideQuest005.ThisQuest.active == true))
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                LoadQuests();
                Debug.Log("Loaded QuestData");

            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                SaveQuests();
                Debug.Log("Saved QuestData");
            }
        }

        
    }

    public void OnMenuStartGameClick() //start of game -- start of Quest 1
    {
        mainQuest001.ThisQuest.SetActive(true);
        CutscenePanel.SetActive(true);
        
        mainQuest001.Cutscene1Video.SetActive(true);
        Invoke(nameof(DeactivateVideos), 6);
    }

    public void DeactivateVideos()
    {
        mainQuest001.Cutscene1Video.SetActive(false);
        mainQuest001.Cutscene2Video.SetActive(false);

        mainQuest002.Cutscene3Video.SetActive(false);

        mainQuest003.Cutscene4Video.SetActive(false);
        mainQuest003.Cutscene5Video.SetActive(false);

        mainQuest004.Cutscene6Video.SetActive(false);
        mainQuest004.Cutscene7Video.SetActive(false);
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



    //Save and Load game
    public void SaveQuests()
    {
        SaveQuestSystem.SaveQuests(this);
        Debug.Log("Saved Game");
    }

    public void LoadQuests()
    {
         QuestData data = SaveQuestSystem.LoadQuests();

        MQ1Done = data.MainQuest1Done;
        MQ2Done = data.MainQuest2Done;
        MQ3Done = data.MainQuest3Done;
        MQ4Done = data.MainQuest4Done;
        MQ5Done = data.MainQuest5Done;

        SQ1Done = data.SideQuest1Done;
        SQ2Done = data.SideQuest2Done;
        SQ3Done = data.SideQuest3Done;
        SQ4Done = data.SideQuest4Done;
        SQ5Done = data.SideQuest5Done;

        MQ2StartTrigger.SetActive(false);
        MQ3StartTrigger.SetActive(false);
        MQ4StartTrigger.SetActive(false);
        MQ5StartTrigger.SetActive(false);

        SQ1StartTrigger.SetActive(false);
        SQ2StartTrigger.SetActive(false);
        SQ3StartTrigger.SetActive(false);
        SQ4StartTrigger.SetActive(false);
        SQ5StartTrigger.SetActive(false);

        if (MQ5Done)
        {
            //nothing
        }
        else if (MQ4Done)
        {
            MQ5StartTrigger.SetActive(true);
        }
        else if (MQ3Done)
        {
            MQ4StartTrigger.SetActive(true);
        }
        else if (MQ2Done)
        {
            MQ3StartTrigger.SetActive(true);
        }
        else if (MQ1Done)
        {
            MQ2StartTrigger.SetActive(true);
        }

        if (!SQ1Done)
        {
            SQ1StartTrigger.SetActive(true);
        }
        if (!SQ2Done)
        {
            SQ2StartTrigger.SetActive(true);
        }
        if (!SQ3Done)
        {
            SQ3StartTrigger.SetActive(true);
        }
        if (!SQ4Done)
        {
            SQ4StartTrigger.SetActive(true);
        }
        if (!SQ5Done)
        {
            SQ5StartTrigger.SetActive(true);
        }

        Debug.Log("Loaded Game");
    }

}
