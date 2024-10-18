using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideQuest003 : MonoBehaviour
{
    [Header("Wave Parent Ojects")]
    public GameObject EnemyWave1;
    public GameObject EnemyWave2;
    public GameObject EnemyWave3;
    public GameObject EnemyWave4;
    public GameObject EnemyWave5;


    [Header("Enemy Counter")]
    public int TotalEnemies;
    //public int EnemiesDefeated;
    public int WaveCounter;

    [Header("Quest Game Object")]
    public GameObject ThisQuest;
    [Header("HUD Script")]
    public HUD hud;
    [Header("Master Quest Handler Script")]
    public MasterQuestHandler masterQuestHandler;

    [Header("Other Variables")]
    //public GameObject EndQuestTrigger;
    public GameObject StartQuestTrigger;
    public GameObject WaveQuestTrigger;

    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);
        //EnemiesDefeated = 0;
        TotalEnemies = 0;
        WaveCounter = 0;

        EnemyWave1.SetActive(false);
        EnemyWave2.SetActive(false);
        EnemyWave3.SetActive(false);
        EnemyWave4.SetActive(false);
        EnemyWave5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ThisQuest.active == true)
        {
            hud.QuestTitleText.text = "An irl human (_side_quest_003_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText = "Wave: " + WaveCounter.ToString() + "\nEnemies: " + TotalEnemies.ToString(); ;
        }
    }

    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        //EndQuestTrigger.SetActive(false);

        ObjectiveText = "Investigate Crash Area";
        //tutText = "Is there another human???";

        masterQuestHandler.DeactivateSideQuestStartTriggers();

        WaveQuestTrigger.SetActive(false);

        PlayDialogue();



    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_side_quest_003_StartCoroutine_Auto == An irl human";
        hud.WonQuestObjectivesText.text = "Found the 'real' human";

        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.SQ3Done = true;
    }


    //---------------------Enemies-----------------------------------

    public void SpawnWave1()
    {
        WaveCounter = 1;
        TotalEnemies = 3;
        EnemyWave1.SetActive(true);
        Invoke(nameof(SpawnWave2), 24);
    }

    public void SpawnWave2()
    {
        WaveCounter = 2;
        TotalEnemies = 4;
        EnemyWave2.SetActive(true);
        Invoke(nameof(SpawnWave3), 24);
    }

    public void SpawnWave3()
    {
        WaveCounter = 3;
        TotalEnemies = 5;
        EnemyWave3.SetActive(true);
        Invoke(nameof(SpawnWave4), 24);
    }

    public void SpawnWave4()
    {
        WaveCounter = 4;
        TotalEnemies = 6;
        EnemyWave4.SetActive(true);
        Invoke(nameof(SpawnWave5), 24);
    }

    public void SpawnWave5()
    {
        WaveCounter = 5;
        TotalEnemies = 7;
        EnemyWave5.SetActive(true);
        Invoke(nameof(DespawnWaves), 48);
        Invoke(nameof(EndQuest), 48);
    }

    public void DespawnWaves()
    {
        EnemyWave1.SetActive(false);
        EnemyWave2.SetActive(false);
        EnemyWave3.SetActive(false);
        EnemyWave4.SetActive(false);
        EnemyWave5.SetActive(false);
    }

    //---------------------Dialogue-----------------------------------

    public void PlayDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "113";
        hud.SubtitlesText.text = "Hello. Designation. 808. I. Have. Found. A. Real. Human.";
        masterQuestHandler.dialogueScript.SQ3_GP_VoiceLine001.Play();
        Invoke(nameof(DialogueContinue001), 6);
        Invoke(nameof(DialogueContinue002), 12);
        Invoke(nameof(DialogueContinue003), 18);
        Invoke(nameof(DialogueContinue004), 24);
        Invoke(nameof(DialogueContinue005), 30);
        Invoke(nameof(EndDialogue), 36);
    }

    private void DialogueContinue001()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "What? Elaborate.";
        masterQuestHandler.dialogueScript.SQ3_GP_VoiceLine002.Play();
    }

    private void DialogueContinue002()
    {
        hud.DialogueSpeakerText.text = "113";
        hud.SubtitlesText.text = "It. Is. In. The. Crater. Down. There. Right. Now.";
        masterQuestHandler.dialogueScript.SQ3_GP_VoiceLine003.Play();
    }

    private void DialogueContinue003()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "There. Is. Another?";
        masterQuestHandler.dialogueScript.SQ3_GP_VoiceLine004.Play();
    }

    private void DialogueContinue004()
    {
        hud.DialogueSpeakerText.text = "113";
        hud.SubtitlesText.text = "'Another'? Elaborate.";
        masterQuestHandler.dialogueScript.SQ3_GP_VoiceLine005.Play();
    }

    private void DialogueContinue005()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Goodbye. Must. Investigate.";
        masterQuestHandler.dialogueScript.SQ3_GP_VoiceLine006.Play();

        WaveQuestTrigger.SetActive(true);
    }


    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }

}
