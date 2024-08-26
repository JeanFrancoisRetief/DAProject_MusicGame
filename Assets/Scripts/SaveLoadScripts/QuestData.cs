using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestData
{
    public bool MainQuest1Done;
    public bool MainQuest2Done;
    public bool MainQuest3Done;
    public bool MainQuest4Done;
    public bool MainQuest5Done;

    public bool SideQuest1Done;
    public bool SideQuest2Done;
    public bool SideQuest3Done;
    public bool SideQuest4Done;
    public bool SideQuest5Done;

    public QuestData (MasterQuestHandler masterQuestHandlerScript) //constructor (store level done data)
    {
        MainQuest1Done = masterQuestHandlerScript.MQ1Done;
        MainQuest2Done = masterQuestHandlerScript.MQ2Done;
        MainQuest3Done = masterQuestHandlerScript.MQ3Done;
        MainQuest4Done = masterQuestHandlerScript.MQ4Done;
        MainQuest5Done = masterQuestHandlerScript.MQ5Done;

        SideQuest1Done = masterQuestHandlerScript.SQ1Done;
        SideQuest2Done = masterQuestHandlerScript.SQ2Done;
        SideQuest3Done = masterQuestHandlerScript.SQ3Done;
        SideQuest4Done = masterQuestHandlerScript.SQ4Done;
        SideQuest5Done = masterQuestHandlerScript.SQ5Done;
    }
}
