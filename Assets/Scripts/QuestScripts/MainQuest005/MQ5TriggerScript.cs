using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MQ5TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public MainQuest005 mainQuest005Script;

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
        if(other.tag == "Player")
        {
            if (TriggerType == Quest_Trigger_Type.START)
            {
                mainQuest005Script.StartQuest();
                gameObject.transform.position = new Vector3(0, -500, 0);
            }

            if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
            {
                //n.a
            }

            if (TriggerType == Quest_Trigger_Type.PlayCutscene)
            {
                mainQuest005Script.PlayCutscene8();
                gameObject.transform.position = new Vector3(0, -900, 0);
            }

            if (TriggerType == Quest_Trigger_Type.PlayDialogue)
            {
                //n.a
            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                //n.a
            }
        }

        

    }
}
