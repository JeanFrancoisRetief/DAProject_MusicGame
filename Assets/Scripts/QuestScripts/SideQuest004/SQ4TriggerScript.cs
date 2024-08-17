using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQ4TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public SideQuest004 sideQuest004Script;

    public enum Quest_Trigger_Type
    {
        START,
        SpawnEnemies,
        PlayCutscene,
        PlayDialogue,
        Choice001,
        Choice002,
        Choice003,
        Choice004,
        Choice005,
        Choice006,
        Choice007,
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
        if (other.tag == "Player")
        {
            if (TriggerType == Quest_Trigger_Type.START)
            {
                sideQuest004Script.StartQuest();
                gameObject.transform.position = new Vector3(-800, -500, 800);//get it away
            }

            if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
            {
                sideQuest004Script.SpawnEnemies();
            }

            if (TriggerType == Quest_Trigger_Type.PlayCutscene)
            {
                //n.a.
            }

            if (TriggerType == Quest_Trigger_Type.Choice001)
            {
                sideQuest004Script.PlayNarration001();
            }
            if (TriggerType == Quest_Trigger_Type.Choice002)
            {
                sideQuest004Script.PlayNarration002();
            }
            if (TriggerType == Quest_Trigger_Type.Choice003)
            {
                sideQuest004Script.PlayNarration003();
            }
            if (TriggerType == Quest_Trigger_Type.Choice004)
            {
                sideQuest004Script.PlayNarration004();
            }
            if (TriggerType == Quest_Trigger_Type.Choice005)
            {
                sideQuest004Script.PlayNarration005();
            }
            if (TriggerType == Quest_Trigger_Type.Choice006)
            {
                sideQuest004Script.PlayNarration006();
            }
            if (TriggerType == Quest_Trigger_Type.Choice007)
            {
                sideQuest004Script.PlayNarration007();
            }

            if (TriggerType == Quest_Trigger_Type.PlayDialogue)
            {
                sideQuest004Script.PlayDialogue();
            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                sideQuest004Script.EndQuest();
            }
        }
            

    }
}
