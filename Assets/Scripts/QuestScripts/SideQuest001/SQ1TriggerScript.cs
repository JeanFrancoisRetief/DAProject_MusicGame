using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQ1TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public SideQuest001 sideQuest001Script;

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
        if (other.tag == "Player")
        {
            if (TriggerType == Quest_Trigger_Type.START)
            {
                sideQuest001Script.StartQuest();

            }

            if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
            {
                //sideQuest001Script.SpawnWave1();
            }

            if (TriggerType == Quest_Trigger_Type.PlayCutscene)
            {
                //n.a. 
            }

            if (TriggerType == Quest_Trigger_Type.PlayDialogue)
            {
                //n.a. start of quest
            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                //n.a. after wave 5
            }
            gameObject.transform.position = new Vector3(0, -500, 0);
        }

    }
}
