using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest005 : MonoBehaviour
{
    public Credits CreditsScript;

    public GameObject Player;

    [Header("Spawn Enemies")]
    public GameObject Boss001;
    public EnemyScript Boss001ScriptHolder;
    public GameObject Wave1;
    public GameObject Wave2;
    public GameObject Wave3;

    [Header("Teleport Points")]
    public Transform MovePlayerPos;
    public Transform MovePlayerBackPos;


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
    //public GameObject EndQuestTrigger;
    public GameObject StartQuestTrigger;


    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    //[HideInInspector] public bool isCreditsRolling;

    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);
        CreditsScript.isCreditsRolling = false;

        Boss001.SetActive(false);
        Wave1.SetActive(false);
        Wave2.SetActive(false);
        Wave3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "All for 001, 001 for All (_main_quest_005_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText;


            if(Boss001ScriptHolder.Health <= 0)
            {
                PlayCutscene9();
                Boss001.SetActive(false);
                Wave1.SetActive(false);
                Wave2.SetActive(false);
                Wave3.SetActive(false);
            }

            if(CreditsScript.isCreditsDone == true)
            {
                EndQuest();
            }

            if(CreditsScript.isCreditsRolling == true)
            {
                masterQuestHandler.CutscenePanel.SetActive(false);
                Cutscene8Video.SetActive(false);
                Cutscene9Video.SetActive(false);
            }    
            
        }
    }

    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        //EndQuestTrigger.SetActive(false);

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
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine001.Play();

        Invoke(nameof(ContinueDialogue001), 7);
        Invoke(nameof(ContinueDialogue002), 8);
        Invoke(nameof(ContinueDialogue003), 14);
        Invoke(nameof(ContinueDialogue004), 16);
        Invoke(nameof(ContinueDialogue005), 22);
        Invoke(nameof(ContinueDialogue006), 29);
        Invoke(nameof(ContinueDialogue007), 34);
        Invoke(nameof(ContinueDialogue008), 38);
        Invoke(nameof(ContinueDialogue009), 43);
        Invoke(nameof(ContinueDialogue010), 50);
        Invoke(nameof(ContinueDialogue011), 52);

        Invoke(nameof(EndDialogue), 54);

    }

    public void ContinueDialogue001()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "(Sarcastically) I would never.";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine002.Play();
    }
    public void ContinueDialogue002()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "You do realise it is probably… no, DEFINITELY a trap!";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine003.Play();
    }

    public void ContinueDialogue003()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "I do, it is also an opportunity.";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine004.Play();
    }

    public void ContinueDialogue004()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "An opportunity to DIE, Bob! To be permanently deleted from this world TO PUT IT IN ROBOT TERMS!";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine005.Play();
    }

    public void ContinueDialogue005()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "It’s an opportunity to actually meet 001, and stop him. This “party” is a trap, but not for me.";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine006.Play();
    }

    public void ContinueDialogue006()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "No, no… It is definitely a trap for you. You… Specifically.";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine007.Play();
    }

    public void ContinueDialogue007()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "It’s actually probably a trap for you too, hence me not telling you I’m going.";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine008.Play();
    }

    public void ContinueDialogue008()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "That Lighting bolt fried your circuits worse than I thought! GET BACK HERE RIGHT NOW!";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine009.Play();
    }

    public void ContinueDialogue009()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "I need to protect you. (Coldy) Stay. There. Stay. Out. Of. Site. Combat. Protocol. Engaged.";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine010.Play();
    }

    public void ContinueDialogue010()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE (over radio)";
        hud.SubtitlesText.text = "Bob, no! Stop!";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine011.Play();
    }

    public void ContinueDialogue011()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Goodbye, Kate. (Cuts off radio)";
        masterQuestHandler.dialogueScript.MQ5_GP_VoiceLine012.Play();
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
        Invoke(nameof(StopCutscenes), 41);

        Invoke(nameof(MovePlayer), 41);

        Invoke(nameof(Spawn001), 43);


    }

    public void PlayCutscene9()
    {
        
        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene9Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 46);

        Invoke(nameof(MovePlayerBack), 46);
        Invoke(nameof(RollCredits), 46);


    }

    public void StopCutscenes()
    {
        masterQuestHandler.DeactivateVideos();
    }

    public void MovePlayer()
    {
        Player.SetActive(false);
        Player.transform.position = MovePlayerPos.position;
        Player.SetActive(true);
    }

    public void MovePlayerBack()
    {
        Player.SetActive(false);
        Player.transform.position = MovePlayerBackPos.position;
        Player.SetActive(true);
    }

    public void RollCredits()
    {
        CreditsScript.isCreditsRolling = true;
    }
    //---------------------------ENEMIES---------------------------------------

    public void Spawn001()
    {
        Boss001.SetActive(true);
        Invoke(nameof(Spawn002), 6);
        Invoke(nameof(Spawn003), 12);
        Invoke(nameof(Spawn004), 18);
    }


    public void Spawn002()
    {
        
        Wave1.SetActive(true);
    }


    public void Spawn003()
    {
        
        Wave2.SetActive(true);
    }


    public void Spawn004()
    {
        
        Wave3.SetActive(true);
    }

}
