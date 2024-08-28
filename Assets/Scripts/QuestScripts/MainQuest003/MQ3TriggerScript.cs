using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MQ3TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public MainQuest003 mainQuest003Script;

    public enum Quest_Trigger_Type
    {
        START,
        SpawnEnemies,
        PlayCutscene,
        PlayDialogue,
        END
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (TriggerType == Quest_Trigger_Type.START)
        {
            mainQuest003Script.StartQuest();
        }

        if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
        {
            //n.a. 
        }

        if (TriggerType == Quest_Trigger_Type.PlayCutscene)
        {
            //n.a. 
        }

        if (TriggerType == Quest_Trigger_Type.PlayDialogue)
        {
            mainQuest003Script.DialogueTriggered();
        }

        if (TriggerType == Quest_Trigger_Type.END)
        {
            //n.a. after dialogue
        }

    }
}
