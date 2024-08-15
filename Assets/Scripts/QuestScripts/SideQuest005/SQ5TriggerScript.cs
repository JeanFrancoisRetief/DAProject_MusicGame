using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQ5TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public SideQuest005 sideQuest005Script;

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

        }

        if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
        {

        }

        if (TriggerType == Quest_Trigger_Type.PlayCutscene)
        {

        }

        if (TriggerType == Quest_Trigger_Type.PlayDialogue)
        {

        }

        if (TriggerType == Quest_Trigger_Type.END)
        {

        }

    }
}
