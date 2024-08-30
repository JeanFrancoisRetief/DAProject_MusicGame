using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest005 : MonoBehaviour
{
    [Header("Video Parent Objects")]
    public GameObject Cutscene8Video;
    public GameObject Cutscene9Video;

    [Header("Quest Game Object")]
    public GameObject ThisQuest;
    [Header("HUD Script")]
    public HUD hud;
    [Header("Master Quest Handler Script")]
    public MasterQuestHandler masterQuestHandler;

    [Header("Other Variables")]
    public GameObject EndQuestTrigger;
    public GameObject StartQuestTrigger;

    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    [HideInInspector] public bool isCreditsRolling;
    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);
        isCreditsRolling = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "All for 001, 001 for All (_main_quest_005_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText;
        }
    }

    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        EndQuestTrigger.SetActive(false);

        ObjectiveText = "Go to “the party” at the mansion";
        tutText = "Probably a trap";

        masterQuestHandler.DeactivateSideQuestStartTriggers();

        PlayDialogue();


    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_main_quest_005_StartCoroutine_Auto == All for 001, 001 for All";
        hud.WonQuestObjectivesText.text = "Helped Kate.\nCollected 10 packages.";

        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.MQ5Done = true;
    }

    //---------------------Dialogue-----------------------------------

    public void PlayDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "Where are you? You’re… You’re not going to that party-thing 001 is talking about on every channel?";

        Invoke(nameof(ContinueDialogue001), 6);
        Invoke(nameof(ContinueDialogue002), 12);
        Invoke(nameof(ContinueDialogue003), 18);
        Invoke(nameof(ContinueDialogue004), 24);
        Invoke(nameof(ContinueDialogue005), 30);
        Invoke(nameof(ContinueDialogue006), 36);
        Invoke(nameof(ContinueDialogue007), 42);
        Invoke(nameof(ContinueDialogue008), 48);
        Invoke(nameof(ContinueDialogue009), 54);
        Invoke(nameof(ContinueDialogue010), 60);
        Invoke(nameof(ContinueDialogue011), 66);

        Invoke(nameof(EndDialogue), 72);

    }

    public void ContinueDialogue001()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "(Sarcastically) I would never.";
    }
    public void ContinueDialogue002()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "You do realise it is probably… no, DEFINITELY a trap!";
    }

    public void ContinueDialogue003()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "I do, it is also an opportunity.";
    }

    public void ContinueDialogue004()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "An opportunity to DIE, Bob! To be permanently deleted from this world TO PUT IT IN ROBOT TERMS!";
    }

    public void ContinueDialogue005()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "It’s an opportunity to actually meet 001, and stop him. This “party” is a trap, but not for me.";
    }

    public void ContinueDialogue006()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "No, no… It is definitely a trap for you. You… Specifically.";
    }

    public void ContinueDialogue007()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "It’s actually probably a trap for you too, hence me not telling you I’m going.";
    }

    public void ContinueDialogue008()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "That Lighting bolt fried your circuits worse than I thought! GET BACK HERE RIGHT NOW!";
    }

    public void ContinueDialogue009()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "I need to protect you. (Coldy) Stay. There. Stay. Out. Of. Site. Combat. Protocol. Engaged.";
    }

    public void ContinueDialogue010()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "Bob, no! Stop!";
    }

    public void ContinueDialogue011()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Goodbye, Kate. (Cuts off radio)";
    }



    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }

    //---------------------Narritive-----------------------------------
    public void PlayCutscene8()
    {
        //Trigger event
        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene8Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);

        Invoke(nameof(MovePlayer), 10);
        

    }

    public void PlayCutscene9()
    {
        //Trigger event
        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene9Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);

        Invoke(nameof(MovePlayerBack), 10);
        Invoke(RollCredits, 10);


    }

    public void StopCutscenes()
    {
        masterQuestHandler.DeactivateVideos();
    }

    public void MovePlayer()
    {
        
    }

    public void MovePlayerBack()
    {
        
    }

    public void RollCredits()
    {
        isCreditsRolling = true;
    }

}
