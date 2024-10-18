using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest004 : MonoBehaviour
{
    [Header("Player Kate Script")]
    public PlayerKate playerKateScript;

    [Header("Video Parent Objects")]
    public GameObject Cutscene6Video;
    public GameObject Cutscene7Video;

    [Header("Quest Game Object")]
    public GameObject ThisQuest;
    [Header("HUD Script")]
    public HUD hud;
    [Header("Master Quest Handler Script")]
    public MasterQuestHandler masterQuestHandler;

    [Header("Other Variables")]
    public GameObject EndQuestTrigger;
    public GameObject StartQuestTrigger;

    public int packagesCollected;

    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);

        packagesCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "The Feature called ‘Empathy’ (_main_quest_004_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText;
           
            tutText = "Walk / run towards fallen packages and collect them off of the ground before enemy robots intercept them.\nPackages Collected "
            + packagesCollected.ToString() + " / 10\nKate can't fly, or melee attack";
            hud.TutorialText.text = tutText;
        }
    }

    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        EndQuestTrigger.SetActive(false);

        ObjectiveText = "Help 808";
        

        masterQuestHandler.DeactivateSideQuestStartTriggers();

        playerKateScript.SwitchToKate(); //Change player character

        PlayCutscene6();


    }

    public void EndQuest()
    {
        playerKateScript.SwitchTo808(); //Change player character


        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_main_quest_004_StartCoroutine_Auto == The Feature called ‘Empathy’";
        hud.WonQuestObjectivesText.text = "Helped Kate.\nCollected 10 packages.";

        masterQuestHandler.MQ5StartTrigger.SetActive(true);//start of next main quest
        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.MQ4Done = true;
    }

    //---------------------Narritve----------------------------------------------------------
    public void PlayCutscene6()
    {

        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene6Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);
        Invoke(nameof(PlayDialogue001), 12);

    }

    public void PlayCutscene7()
    {

        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene7Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);
        Invoke(nameof(EndQuest), 10);

    }

    public void StopCutscenes()
    {
        masterQuestHandler.DeactivateVideos();
    }

    //---------------------Dialogue-----------------------------------

    public void PlayDialogue001()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "I have to help him. There are some packages around town that he didn’t collect on his flying excursion getting my supplies.";
        masterQuestHandler.dialogueScript.MQ4_GP_VoiceLine001.Play();
        Invoke(nameof(EndDialogue), 6);
        
    }

    public void PlayDialogue002()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "I still need more supplies.";
        masterQuestHandler.dialogueScript.MQ4_GP_VoiceLine002.Play();
        Invoke(nameof(EndDialogue), 6);

    }

    public void PlayDialogue003()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "I can’t let him down.";
        masterQuestHandler.dialogueScript.MQ4_GP_VoiceLine003.Play();
        Invoke(nameof(EndDialogue), 6);

    }

    public void PlayDialogue004()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "I can’t let him die!";
        masterQuestHandler.dialogueScript.MQ4_GP_VoiceLine004.Play();
        Invoke(nameof(EndDialogue), 6);

    }

    public void PlayDialogue005()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "Okay, that’s enough, back to the lab! I have to save him.";
        masterQuestHandler.dialogueScript.MQ4_GP_VoiceLine005.Play();
        Invoke(nameof(EndDialogue), 6);

    }

    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }





}
