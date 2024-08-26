using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest002 : MonoBehaviour
{
    [Header("Video Parent Objects")]
    public GameObject Cutscene3Video;
    [Header("Quest Game Object")]
    public GameObject ThisQuest;
    [Header("HUD Script")]
    public HUD hud;
    [Header("Master Quest Handler Script")]
    public MasterQuestHandler masterQuestHandler;
    [Header("Care Packages")]
    public float packagesCollected;
    public GameObject CarePackageObject001;
    public GameObject CarePackageObject002;
    public GameObject CarePackageObject003;
    public GameObject CarePackageObject004;
    public GameObject CarePackageObject005;
    public GameObject CarePackageObject006;
    public GameObject CarePackageObject007;
    public GameObject CarePackageObject008;
    public GameObject CarePackageObject009;
    public GameObject CarePackageObject010;
    [Header("Other Variables")]
    public GameObject EndQuestTrigger;
    public GameObject StartQuestTrigger;

    //[Header("Other Variables")]
    [HideInInspector] public float CP001Ypos;
    [HideInInspector] public float CP002Ypos;
    [HideInInspector] public float CP003Ypos;
    [HideInInspector] public float CP004Ypos;
    [HideInInspector] public float CP005Ypos;
    [HideInInspector] public float CP006Ypos;
    [HideInInspector] public float CP007Ypos;
    [HideInInspector] public float CP008Ypos;
    [HideInInspector] public float CP009Ypos;
    [HideInInspector] public float CP010Ypos;


    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "Sustenance. For. Survival. (_main_quest_002_StartCoroutine_Auto)";
            ObjectiveText = "Care packages collected " + packagesCollected.ToString() + " / 10";
            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText;

            if(packagesCollected == 10)
            {
                ObjectiveText = "Go back to nearby farm house";
                tutText = "It is next to the nearby barn";
                SpawnEndQuestTrigger();
            }

            //Reset
            if(CP001Ypos <= 3)
            {
                CP001Ypos = 101;
            }
            if (CP002Ypos <= 3)
            {
                CP002Ypos = 101;
            }
            if (CP003Ypos <= 3)
            {
                CP003Ypos = 101;
            }
            if (CP004Ypos <= 3)
            {
                CP004Ypos = 101;
            }
            if (CP005Ypos <= 3)
            {
                CP005Ypos = 101;
            }
            if (CP006Ypos <= 3)
            {
                CP006Ypos = 101;
            }
            if (CP007Ypos <= 3)
            {
                CP007Ypos = 101;
            }
            if (CP008Ypos <= 3)
            {
                CP008Ypos = 101;
            }
            if (CP009Ypos <= 3)
            {
                CP009Ypos = 101;
            }
            if (CP010Ypos <= 3)
            {
                CP010Ypos = 101;
            }

            //Fall
            CP001Ypos -= 0.1f;
            CarePackageObject001.transform.position = new Vector3(CarePackageObject001.transform.position.x, CP001Ypos, CarePackageObject001.transform.position.z);
            CP002Ypos -= 0.1f;
            CarePackageObject002.transform.position = new Vector3(CarePackageObject002.transform.position.x, CP002Ypos, CarePackageObject002.transform.position.z);
            CP003Ypos -= 0.1f;
            CarePackageObject003.transform.position = new Vector3(CarePackageObject003.transform.position.x, CP003Ypos, CarePackageObject003.transform.position.z);
            CP004Ypos -= 0.1f;
            CarePackageObject004.transform.position = new Vector3(CarePackageObject004.transform.position.x, CP004Ypos, CarePackageObject004.transform.position.z);
            CP005Ypos -= 0.1f;
            CarePackageObject005.transform.position = new Vector3(CarePackageObject005.transform.position.x, CP005Ypos, CarePackageObject005.transform.position.z);
            CP006Ypos -= 0.1f;
            CarePackageObject006.transform.position = new Vector3(CarePackageObject006.transform.position.x, CP006Ypos, CarePackageObject006.transform.position.z);
            CP007Ypos -= 0.1f;
            CarePackageObject007.transform.position = new Vector3(CarePackageObject007.transform.position.x, CP007Ypos, CarePackageObject007.transform.position.z);
            CP008Ypos -= 0.1f;
            CarePackageObject008.transform.position = new Vector3(CarePackageObject008.transform.position.x, CP008Ypos, CarePackageObject008.transform.position.z);
            CP009Ypos -= 0.1f;
            CarePackageObject009.transform.position = new Vector3(CarePackageObject009.transform.position.x, CP009Ypos, CarePackageObject009.transform.position.z);
            CP010Ypos -= 0.1f;
            CarePackageObject010.transform.position = new Vector3(CarePackageObject010.transform.position.x, CP010Ypos, CarePackageObject010.transform.position.z);

        }
    }
    
    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        EndQuestTrigger.SetActive(false);
        tutText = "Press Space To Jump\nDouble Press Space while in the air to engage/disengage flight mode.\nFly towards falling packages and collect them before they reach the ground.";
        //ObjectiveText = "Collected 0 / 10";
        packagesCollected = 0;
        masterQuestHandler.DeactivateSideQuestStartTriggers();

        CP001Ypos = CarePackageObject001.transform.position.y;
        CP002Ypos = CarePackageObject002.transform.position.y;
        CP003Ypos = CarePackageObject003.transform.position.y;
        CP004Ypos = CarePackageObject004.transform.position.y;
        CP005Ypos = CarePackageObject005.transform.position.y;
        CP006Ypos = CarePackageObject006.transform.position.y;
        CP007Ypos = CarePackageObject007.transform.position.y;
        CP008Ypos = CarePackageObject008.transform.position.y;
        CP009Ypos = CarePackageObject009.transform.position.y;
        CP010Ypos = CarePackageObject010.transform.position.y;

        PlayDialogue();//at start of quest
    }

    public void PlayDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Must. Intercept. Care-Packages. Before. Packages. Make. Landfall. Engage. Maximum. Thrust.";
        Invoke(nameof(EndDialogue), 8);
    }

    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }

    public void PackageCollect()
    {
        packagesCollected++;
    }

    public void SpawnEndQuestTrigger()
    {
        EndQuestTrigger.SetActive(true);
    }

    public void PlayCutscene3()
    {
        
        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene3Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);
        Invoke(nameof(EndQuest), 10);
    }

    public void StopCutscenes()
    {
        masterQuestHandler.DeactivateVideos();
    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_main_quest_002_StartCoroutine_Auto == Operation SFS: Sustenance. For. Survival.";
        hud.WonQuestObjectivesText.text = "Collected 10 care packages\nYou now have enough food and medical\nsupplies for the human";

        masterQuestHandler.MQ3StartTrigger.SetActive(true);//start of next main quest
        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.MQ2Done = true;
    }



}
