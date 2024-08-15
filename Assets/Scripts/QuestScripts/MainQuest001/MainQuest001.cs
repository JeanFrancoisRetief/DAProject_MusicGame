using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest001 : MonoBehaviour
{
    [Header("Video Parent Objects")]
    public GameObject Cutscene1Video;
    public GameObject Cutscene2Video;
    [Header("Quest Game Object")]
    public GameObject ThisQuest;
    [Header("HUD Script")]
    public HUD hud;
    [Header("Master Quest Handler Script")]
    public MasterQuestHandler masterQuestHandler;

    private string tutText;
    private string ObjectiveText;
    // Start is called before the first frame update
    void Start()
    {
        tutText = "WASD to walk\nMouse to use look around";
        ObjectiveText = "Chase the human";
    }

    // Update is called once per frame
    void Update()
    {
        if(ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "Close Encounter (_main_quest_001_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText; 
            hud.TutorialText.text = tutText;
        }
    }

    public void ShowTutPrompt002()
    {
        tutText = "Hold Left mouse click for melee spin attack\nHold Right mouse click to aim for ranged attack\nHold both Right and Left mouse click to fire lasers";
    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_main_quest_001_StartCoroutine_Auto == Close Encounter with humankind";
        hud.WonQuestObjectivesText.text = "Chased the human\nTalked to the human\nWent to farm house";

    }

    public void PlayCutscene2()
    {
        ObjectiveText = "Go to farm house";
        tutText = "It is next to the barn";
        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene2Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);
    }

    public void StopCutscenes()
    {
        masterQuestHandler.DeactivateVideos();
    }

    //Dialogue Scripts
    public void PlayDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "INJURED HUMAN";
        hud.SubtitlesText.text = "(Confused)If you�re going to kill me just do it already!";
        Invoke(nameof(DialogueContinue001), 6);
        Invoke(nameof(DialogueContinue002), 12);
        Invoke(nameof(DialogueContinue003), 18);
        Invoke(nameof(EndDialogue),24);
    }

    private void DialogueContinue001()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "(Resolute)Kill. You? Why. Would. 808. Kill. Doctor. Erin?";
    }

    private void DialogueContinue002()
    {
        hud.DialogueSpeakerText.text = "INJURED HUMAN";
        hud.SubtitlesText.text = "(Confused)All robots want humans dead nowadays! Wait, did you say Erin?";
    }

    private void DialogueContinue003()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "(Overridden with medical subroutine) You. Require. Medical. Assistance.";
    }

    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }

}
