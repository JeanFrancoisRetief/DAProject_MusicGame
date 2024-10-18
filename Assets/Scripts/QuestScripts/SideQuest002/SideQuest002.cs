using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideQuest002 : MonoBehaviour
{
    [Header("Quest Game Object")]
    public GameObject ThisQuest;
    [Header("HUD Script")]
    public HUD hud;
    [Header("Master Quest Handler Script")]
    public MasterQuestHandler masterQuestHandler;
    [Header("State Machine Script (READ ONLY PLEASE)")]
    public StateMachineScript stateMachineScript;
    [Header("Band Members")]
    public GameObject Member818;
    public GameObject Member828;
    public GameObject Member838;
    public GameObject Member848;
    public GameObject Member858;
    public GameObject Member868;
    public GameObject Member878;
    [Header("Band End Positions")]
    public Transform Member818EndPos;
    public Transform Member828EndPos;
    public Transform Member838EndPos;
    public Transform Member848EndPos;
    public Transform Member858EndPos;
    public Transform Member868EndPos;
    public Transform Member878EndPos;


    [Header("Other Variables")]
    public GameObject EndQuestTrigger;
    public GameObject StartQuestTrigger;

    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    [HideInInspector] public int BandMemberCounter;
    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);
        BandMemberCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "Getting the 8.A.N.D back together (_side_quest_002_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText;
        }
        if (BandMemberCounter >= 7)
        {
            EndQuestTrigger.SetActive(true);
        }
    }

    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        EndQuestTrigger.SetActive(false);
        ObjectiveText = "Find all the band members";
        tutText = "There all around the town\nThey all prefer different music genres.\nAppeal to their individual tastes.";
        masterQuestHandler.DeactivateSideQuestStartTriggers();

        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "(wondering internally) An. Empty. Stage... I. Wonder. Who. Used. To. Play. Gigs. Here.";
        Invoke(nameof(EndDialogue), 8);

    }

    public void EndOfQuestDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "8-A-N-D";
        hud.SubtitlesText.text = "Thanks. For. Bringing. Us. Back. Together.";
        masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine009.Play();
        Invoke(nameof(EndDialogue), 8);
        Invoke(nameof(EndQuest), 8);
    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_side_quest_002_StartCoroutine_Auto == Getting the 8.A.N.D back together";
        hud.WonQuestObjectivesText.text = "Got the 8.A.N.D back together";

        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.SQ2Done = true;
    }

    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }

    public void InteractWith818()
    {
        if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Default)
        {
            BandMemberCounter++;
            //Teleport
            Member818.transform.position = Member818EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "818";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);

        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "818";
            hud.SubtitlesText.text = "While. I. EXPLORE. I. Always. Leave. My. synthesizer's. Settings. On. DEFAULT. A.K.A. The. Best. Setting.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine002.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }

    public void InteractWith828()
    {
        if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Western)
        {
            BandMemberCounter++;
            //Teleport
            Member828.transform.position = Member828EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "828";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);
        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "828";
            hud.SubtitlesText.text = "I. Love. The. Sounds. Of. A. DUEL. In. Those. Old. Human. WESTERN. Movies. I. Wonder. If. My. Banjo. Can. Recreate. That. Soundscape.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine003.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }

    public void InteractWith838()
    {
        if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Classical)
        {
            BandMemberCounter++;
            //Teleport
            Member838.transform.position = Member838EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "838";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);
        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "838";
            hud.SubtitlesText.text = "The. Path. To. VICTORY. Is. Pathed. By. CLASSICAL. Piano. Melodies.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine004.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }

    public void InteractWith848()
    {
        if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Retro)
        {
            BandMemberCounter++;
            //Teleport
            Member848.transform.position = Member848EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "848";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);
        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "848";
            hud.SubtitlesText.text = "Remember. Those. DEATH. Screens. In. Those. Old. RETRO. Games. I. Can. Make. Those. Tunes. With. My. Voice-Box-Unit.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine005.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }

    public void InteractWith858()
    {
        if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
        {
            BandMemberCounter++;
            //Teleport
            Member858.transform.position = Member858EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "858";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);
        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "858";
            hud.SubtitlesText.text = "My. ARTIFICIAL. INTELLIGENCE. Can. Create. Interesting. STORIES. For. The. Background. Vocals.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine006.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }

    public void InteractWith868()
    {
        if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
        {
            BandMemberCounter++;
            //Teleport
            Member868.transform.position = Member868EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "868";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);
        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "868";
            hud.SubtitlesText.text = "With. My. Drumming. The. Music. Will. Give. The. Feeling. Of. EXPLORING. The. Old. Earth. Land-mass. 'AFRICA.' Did. You. Know. This. Town. Was. Built. In. Africa. Shortly. Before........";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine007.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }

    public void InteractWith878()
    {
        if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
        {
            BandMemberCounter++;
            //Teleport
            Member878.transform.position = Member878EndPos.position;
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "878";
            hud.SubtitlesText.text = "I. Like. Your. Taste. In. Music. I'll. Re-join. To. The. 8-A-N-D.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine001.Play();
            Invoke(nameof(EndDialogue), 8);
        }
        else
        {
            //Dialogue
            hud.DialoguePanel.SetActive(true);
            hud.DialogueSpeakerText.text = "878";
            hud.SubtitlesText.text = "Nothing. Better. Than. An. ACOUSTIC. Guitar. As. A. Backtrack. For. A. Good. Story.";
            masterQuestHandler.dialogueScript.SQ2_GP_VoiceLine008.Play();
            Invoke(nameof(EndDialogue), 8);
        }
    }




}
