using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MQ1TriggerScript : MonoBehaviour
{
    

    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public MainQuest001 mainQuest001Script;

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
                //n.a. - at void start and master quest handler
            }

            if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
            {
                mainQuest001Script.ShowTutPrompt002();
            }

            if (TriggerType == Quest_Trigger_Type.PlayCutscene)
            {
                mainQuest001Script.PlayCutscene2();
            }

            if (TriggerType == Quest_Trigger_Type.PlayDialogue)
            {
                mainQuest001Script.PlayDialogue();
            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                mainQuest001Script.EndQuest();
            }

            transform.position = new Vector3(transform.position.x, transform.position.y - 5, transform.position.z);
        }
            
        

    }
}
