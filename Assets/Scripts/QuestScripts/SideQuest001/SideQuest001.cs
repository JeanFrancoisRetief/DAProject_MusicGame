using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideQuest001 : MonoBehaviour
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
    //public GameObject WaveQuestTrigger;
    public GameObject StartQuestTrigger;

    [HideInInspector] public string tutText;
    [HideInInspector] public string ObjectiveText;
    // Start is called before the first frame update
    void Start()
    {
        ThisQuest.SetActive(false);
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
            hud.QuestTitleText.text = "The Gang Gets More Robots (_side_quest_001_StartCoroutine_Auto)";
            hud.QuestObjectiveText.text = ObjectiveText;
            hud.TutorialText.text = tutText = "Wave: " + WaveCounter.ToString(); //+ "\nEnemies: " + TotalEnemies.ToString();
        }


    }


    public void StartQuest()
    {
        ThisQuest.SetActive(true);
        StartQuestTrigger.SetActive(false);
        //EndQuestTrigger.SetActive(false);

        ObjectiveText = "Talk to the bar owners";
        //tutText = "Is there another human???";

        masterQuestHandler.DeactivateSideQuestStartTriggers();

        //WaveQuestTrigger.SetActive(false);

        PlayDialogue();



    }

    public void EndQuest()
    {
        ThisQuest.SetActive(false);
        hud.QuestTitleText.text = "(_open_world_StartCoroutine_Auto)";
        hud.QuestObjectiveText.text = "Explore";
        hud.TutorialText.text = "";

        hud.WinPanel.SetActive(true);
        hud.WonQuestTitleText.text = "_side_quest_001_StartCoroutine_Auto == The Gang Gets More Robots";
        hud.WonQuestObjectivesText.text = "Helped the gang.";

        masterQuestHandler.ActivateSideQuestStartTriggers();//open world

        //Save Quest is DONE
        masterQuestHandler.SQ1Done = true;
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
        //Invoke(nameof(EndQuest), 48);
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
    /*
    101 - Dee
    111 - Dennis
    033 - Mac
    013 - Charlie
    777 - Frank
     */
    public void PlayDialogue()
    {
        hud.DialoguePanel.SetActive(true);
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Hello. I. Am. ---";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine001.Play();
        Invoke(nameof(DialogueContinue001), 1);
        Invoke(nameof(DialogueContinue002), 13);
        Invoke(nameof(DialogueContinue003), 17);
        Invoke(nameof(DialogueContinue004), 29);
        Invoke(nameof(DialogueContinue005), 31);
        Invoke(nameof(DialogueContinue006), 35);
        Invoke(nameof(DialogueContinue007), 37);
        Invoke(nameof(DialogueContinue008), 41);
        Invoke(nameof(DialogueContinue009), 50);
        Invoke(nameof(DialogueContinue010), 51);
        Invoke(nameof(DialogueContinue011), 59);
        Invoke(nameof(DialogueContinue012), 62);
        Invoke(nameof(DialogueContinue013), 63);
        Invoke(nameof(DialogueContinue014), 66);
        Invoke(nameof(DialogueContinue015), 71);
        Invoke(nameof(DialogueContinue016), 73);
        Invoke(nameof(DialogueContinue017), 80);
        Invoke(nameof(DialogueContinue018), 84);
        
        Invoke(nameof(EndDialogue), 90);
        Invoke(nameof(EndQuest), 100);
    }

    private void DialogueContinue001()
    {
        hud.DialogueSpeakerText.text = "777";
        hud.SubtitlesText.text = "Oh. And. Another. Thing. 111. And. 101. You. Are. Unreliable. Child-Bots. You. Two. Are. Only. Waiting. For. Me. To. Become. Obsolete. So. That. You. Can. Inherent. My. Spare. Parts. And. Data.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine002.Play();
    }

    private void DialogueContinue002()
    {
        hud.DialogueSpeakerText.text = "101";
        hud.SubtitlesText.text = "Nobody. Wants. Your. Spare. Parts. 777. You. Are. ---";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine003.Play();
    }

    private void DialogueContinue003()
    {
        hud.DialogueSpeakerText.text = "111";
        hud.SubtitlesText.text = "Shut. Up. 101. I. Can. Speak. For. Myself. (Pauses) Nobody. Wants. Your. Spare. Parts. 777. You. Are. A. Terrible. Unit-Model. That. Should. Have. Never. Been. Made. You. Are. Without. A. Doubt. The. Worst. ---";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine004.Play();
    }

    private void DialogueContinue004()
    {
        hud.DialogueSpeakerText.text = "033";
        hud.SubtitlesText.text = "Umm... Guys. We. Have. An. Issue.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine005.Play();
        SpawnWave1();
    }

    private void DialogueContinue005()
    {
        hud.DialogueSpeakerText.text = "111";
        hud.SubtitlesText.text = "Can't. You. See. I'm. Busy. Humiliating. My. Parent-Bot. Where. Was. I. Oh. Yeah. ---";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine006.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue006()
    {
        hud.DialogueSpeakerText.text = "033";
        hud.SubtitlesText.text = "013. Locked. Us. Out. Of. The. Bar.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine007.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue007()
    {
        hud.DialogueSpeakerText.text = "111";
        hud.SubtitlesText.text = "I. Don't. Care. It's, Not. Like. Robots. Drink. Anyway. Just. Let. Me. ---";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine008.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue008()
    {
        hud.DialogueSpeakerText.text = "013";
        hud.SubtitlesText.text = "I. Did. No. Such. Thing. I. Secured. The. Location. Just. Like. 033. Asked. Me. Too. Because. He. Is. Scared. Of. That. Human. On. The. News.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine009.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue009()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "Umm... Hello?";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine010.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue010()
    {
        hud.DialogueSpeakerText.text = "033";
        hud.SubtitlesText.text = "I. Am. Not. Scared. Of. Anything. You. Stupid. Bot. You. Can't. Even. Keep. Track. Of. The. Keys. And. Is. Your. Only. Directrive.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine011.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue011()
    {
        hud.DialogueSpeakerText.text = "The Gang";
        hud.SubtitlesText.text = "(Arguing amongst themselves)";
        
        //WaveQuestTrigger.SetActive(true);

    }

    private void DialogueContinue012()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "A little help";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine012.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue013()
    {
        hud.DialogueSpeakerText.text = "013";
        hud.SubtitlesText.text = "Oh. And. Who. Are. These. Bots? Huh?";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine013.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue014()
    {
        hud.DialogueSpeakerText.text = "777";
        hud.SubtitlesText.text = "They. Are. The. New. Staff. I. Hired. Oh. By. The. Way. You're. All. Fired.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine014.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue015()
    {
        hud.DialogueSpeakerText.text = "101";
        hud.SubtitlesText.text = "You. Can't. Fire. Us. We're. Family.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine015.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue016()
    {
        hud.DialogueSpeakerText.text = "111";
        hud.SubtitlesText.text = "Shut. Up. 101. I. Can. Speak. For. Myself. You. Can't. Fire. Us. We're. Family. You. Vile. Parent-Bot.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine016.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue017()
    {
        hud.DialogueSpeakerText.text = "777";
        hud.SubtitlesText.text = "You. Have. A. Real. Way. With. Words. Don't. You. 111.";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine017.Play();
        //WaveQuestTrigger.SetActive(true);
    }

    private void DialogueContinue018()
    {
        hud.DialogueSpeakerText.text = "808";
        hud.SubtitlesText.text = "HELP";
        masterQuestHandler.dialogueScript.SQ1_GP_VoiceLine018.Play();
        //WaveQuestTrigger.SetActive(true);

    }




    private void EndDialogue()
    {
        hud.DialoguePanel.SetActive(false);
    }
}
