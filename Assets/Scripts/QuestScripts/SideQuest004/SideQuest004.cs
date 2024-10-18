using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideQuest004 : MonoBehaviour
{
    public GameObject Enemies;
    public GameObject StangeBuilding;
    public GameObject TwoDoorsPlane;
    public GameObject ReturnPlane1;
    public GameObject ReturnPlane2;
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
            hud.QuestTitleText.text = "The butler parable (_side_quest_004_StartCoroutine_Auto)";
            //hud.QuestObjectiveText.text = ObjectiveText;
            //hud.TutorialText.text = tutText;
        }
    }


    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        EndQuestTrigger.SetActive(false);
        hud.QuestObjectiveText.text = "Talk to the butler";
        hud.TutorialText.text = "Designation serial number: 427";
        masterQuestHandler.DeactivateSideQuestStartTriggers();

        StangeBuilding.SetActive(false);
    }

    public void SpawnEnemies()
    {
        Enemies.SetActive(true);
    }

    //11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
    public void PlayDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "Good. You. Are. Here. Please. Complete. Designated. Task.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine001.Play();
        Invoke(nameof(DialogueContinue001), 4);
        Invoke(nameof(DialogueContinue002), 8);
        Invoke(nameof(DialogueContinue003), 20);
        Invoke(nameof(EndDialogue), 22);
    }

    private void DialogueContinue001()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Elaborate. Term. 'Designated. Task.'";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine002.Play();
    }

    private void DialogueContinue002()
    {
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "The. Help. Are. Getting. Less. Helpful. Each. Cycle. It. Seems. Designated. Task. Description. Follows. Obtain. Rear-Axle-Lubricant. For. Mayor. Bot. 001.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine003.Play();
    }

    private void DialogueContinue003()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Affirmative.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine004.Play();
    }

    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
        ObjectiveText = "Go to the strange building";
        tutText = "It is next to the mansion";
        hud.QuestObjectiveText.text = ObjectiveText;
        hud.TutorialText.text = tutText;
        StangeBuilding.SetActive(true);
    }
    //11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_side_quest_004_StartCoroutine_Auto == The butler-bot did it - a parable";
        hud.WonQuestObjectivesText.text = "Made meaningful player choices that will impact on the rest of the game\nDefinitely, Probably, Maybe.\nNah. It. Wont.";

        //masterQuestHandler.MQ3StartTrigger.SetActive(true);//start of next main quest
        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.SQ4Done = true;
    }
    //11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
    public void PlayNarration001()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "When. 808. Came. To. A. Set. Of. Two. Open. Doors. 808. Took. The. Door. On. Its. Left.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine005.Play();

        hud.QuestObjectiveText.text = "Go through the building";
        hud.TutorialText.text = "";

        Invoke(nameof(EndNarration), 6);
    }

    public void PlayNarration002()
    {
        // 1-0-0-0 go left
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "808. Continued. Towards. The. Storage. Room. Where. It. Found. Two. Unique. Containers. 808. Picked. Up. The. Blue. Container.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine006.Play();
        TwoDoorsPlane.SetActive(true);
        ReturnPlane2.SetActive(true);

        Invoke(nameof(EndNarration), 6);
    }

    public void PlayNarration003()
    {
        // 2-0-0-0 go right
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "808. Took. The. Wrong. Way. 808. Knew. It. Was. Disobeying. Orders. However. 808. Can. Still. Get. Back. On Track. By. Turning. Left.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine008.Play();
        TwoDoorsPlane.SetActive(true);

        Invoke(nameof(EndNarration), 6);
    }

    public void PlayNarration004()
    {
        // 2-1-0-0 go right - return

        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "808. Got. Back. On Track. Towards. The. Storage. Room. Where. It. Found. Two. Containers. 808. Picked. Up. The. Blue. Container. Obey. This. Time.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine009.Play();
        ReturnPlane1.SetActive(true);

        Invoke(nameof(EndNarration), 6);
    }

    public void PlayNarration005()
    {
        // 2-2-0-0 go right - go right

        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "808. Fine. Here. Is. Some. Enemies. I. Guess... And. 808. Died. Horribly.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine010.Play();
        SpawnEnemies();
        StangeBuilding.SetActive(false);
        EndQuestTrigger.SetActive(true);

        hud.QuestObjectiveText.text = "Return to 427";
        hud.TutorialText.text = "427 is nearby";

        Invoke(nameof(EndNarration), 6);
    }

    public void PlayNarration006()
    {
        // 1-1-0-0 go left - Pick up red (wrong)

        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "This. Container. Is. Labeled. 'Rear-Acid-Dissolvent.' 808. Thought. He. Could. Pull. A. Prank. On. 001. 808. Was. Incorrect.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine011.Play();
        SpawnEnemies();
        StangeBuilding.SetActive(false);
        EndQuestTrigger.SetActive(true);

        hud.QuestObjectiveText.text = "Return to 427";
        hud.TutorialText.text = "427 is nearby";

        Invoke(nameof(EndNarration), 6);
    }

    public void PlayNarration007()
    {
        // 1-2-0-0 go left - Pick up blue (correct)

        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "This. Container. Is. Labeled. Rear-Axle-Lubricant. 808. Proceeded. To. Give. It. To. 427.";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine007.Play();
        StangeBuilding.SetActive(false);
        EndQuestTrigger.SetActive(true);

        hud.QuestObjectiveText.text = "Return to 427";
        hud.TutorialText.text = "427 is nearby";

        Invoke(nameof(PlayNarration008), 6);///////////2
        Invoke(nameof(EndNarration), 12);
    }

    public void PlayNarration008()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "427";
        hud.SubtitlesText.text = "808. Performed. Exceptionally. It. Must. Increase. Its. Proud-Parameter. By. 22%";
        masterQuestHandler.dialogueScript.SQ4_GP_VoiceLine007.Play();
        //Invoke(nameof(EndNarration), 6);
    }


    private void EndNarration()
    {
        hud.DialoguePanel.SetActive(false);
    }

    //11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111
}
