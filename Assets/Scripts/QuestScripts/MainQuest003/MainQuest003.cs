using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainQuest003 : MonoBehaviour
{
    [Header("Characters")]
    public GameObject Player;
    public GameObject Kate;



    [Header("Spawn Points")]
    public Transform PlayerPositionSecondObjective;
    /*[Space(5)]
    public Transform EnemySpawnPoint1;
    public Transform EnemySpawnPoint2;
    public Transform EnemySpawnPoint3;
    public Transform EnemySpawnPoint4;
    public Transform EnemySpawnPoint5;
    public Transform EnemySpawnPoint6;
    public Transform EnemySpawnPoint7;
    public Transform EnemySpawnPoint8;*/

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


    [Header("Video Parent Objects")]
    public GameObject Cutscene4Video;
    public GameObject Cutscene5Video;
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
            hud.QuestTitleText.text = "The Bug called ‘Empathy’ (_main_quest_003_StartCoroutine_Auto)";

            if(tutText != "No need to rush")
            {
                tutText = "Wave: " + WaveCounter.ToString() + "\nEnemies: " + TotalEnemies.ToString();
            }
            

            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText;
        }
    }


    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        //EndQuestTrigger.SetActive(false);

        ObjectiveText = "PROTECT KATE";
        //tutText = "Wave: " + WaveCounter.ToString() + "\nEnemies Defeated: " + EnemiesDefeated.ToString() + "/" + TotalEnemies.ToString();
        
        masterQuestHandler.DeactivateSideQuestStartTriggers();

        PlayCutscene4();

        Kate.SetActive(false);


    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_main_quest_003_StartCoroutine_Auto == The Bug called ‘Empathy’";
        hud.WonQuestObjectivesText.text = "Protected Kate.\nBrought Kate somewhere safer.";

        masterQuestHandler.MQ4StartTrigger.SetActive(true);//start of next main quest
        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.MQ3Done = true;
    }

    //---------------------Narritive-----------------------------------

    public void PlayCutscene4()
    {

        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene4Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);
        Invoke(nameof(SpawnWave1), 14);//first wave !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

    }

    public void PlayCutscene5()
    {
        ObjectiveText = "";
        tutText ="";
        masterQuestHandler.CutscenePanel.SetActive(true);
        Cutscene5Video.SetActive(true);
        Invoke(nameof(StopCutscenes), 10);
        Invoke(nameof(SwitchObjective), 10);

    }

    public void SwitchObjective()
    {
        ObjectiveText = "Walk with KATE";
        tutText = "No need to rush";

        //Teleport
        Player.SetActive(false);
        Player.transform.position = PlayerPositionSecondObjective.position;
        Player.SetActive(true);

        //Spawn Kate
        Kate.SetActive(true);

        //Dialogue
        PlayDialogue();



    }

    public void StopCutscenes()
    {
        masterQuestHandler.DeactivateVideos();
    }

    //---------------------Enemies-----------------------------------

    public void SpawnWave1()
    {
        WaveCounter = 1;
        TotalEnemies = 3;
        EnemyWave1.SetActive(true);
        Invoke(nameof(SpawnWave2), 14);
    }

    public void SpawnWave2()
    {
        WaveCounter = 2;
        TotalEnemies = 4;
        EnemyWave2.SetActive(true);
        Invoke(nameof(SpawnWave3), 14);
    }

    public void SpawnWave3()
    {
        WaveCounter = 3;
        TotalEnemies = 5;
        EnemyWave3.SetActive(true);
        Invoke(nameof(SpawnWave4), 14);
    }

    public void SpawnWave4()
    {
        WaveCounter = 4;
        TotalEnemies = 6;
        EnemyWave4.SetActive(true);
        Invoke(nameof(SpawnWave5), 14);
    }

    public void SpawnWave5()
    {
        WaveCounter = 5;
        TotalEnemies = 7;
        EnemyWave5.SetActive(true);
        Invoke(nameof(DespawnWaves), 30);
        Invoke(nameof(PlayCutscene5), 30);
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
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "You’re not starting to worry about lil’ ol’ me. Are you?";
        masterQuestHandler.dialogueScript.MQ3_GP_VoiceLine001.Play();
        Invoke(nameof(DialogueContinue001), 6);
        Invoke(nameof(DialogueContinue002), 12);
        Invoke(nameof(DialogueContinue003), 18);
        Invoke(nameof(DialogueContinue004), 24);
        Invoke(nameof(EndDialogue), 30);
    }

    private void DialogueContinue001()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "No! That’s just my compassionEmpathy.scrpt file acting up!";
        masterQuestHandler.dialogueScript.MQ3_GP_VoiceLine002.Play();
    }

    private void DialogueContinue002()
    {
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "Sure thing, Bob.";
        masterQuestHandler.dialogueScript.MQ3_GP_VoiceLine003.Play();
    }

    private void DialogueContinue003()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Call me that again and I’ll deactivate this bug-ridden code in my system.";
        masterQuestHandler.dialogueScript.MQ3_GP_VoiceLine004.Play();
    }

    private void DialogueContinue004()
    {
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "That’s not a bug, it’s definitely a feature, (Pauses) Bob.";
        masterQuestHandler.dialogueScript.MQ3_GP_VoiceLine005.Play();
    }

    public void DialogueTriggered()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "KATE";
        hud.SubtitlesText.text = "I’ll head inside, so long. You go out and explore if you want. To keep up appearances. Or you can just (mockingly) “Follow. Me. Inside”";
        masterQuestHandler.dialogueScript.MQ3_GP_VoiceLine006.Play();
        Invoke(nameof(EndDialogue), 6);
        Invoke(nameof(EndQuest), 6);
    }

    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }

}
