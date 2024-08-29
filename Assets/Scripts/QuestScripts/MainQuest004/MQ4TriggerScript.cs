using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MQ4TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public MainQuest004 mainQuest004Script;
    [Header("ParentObject")]
    public GameObject ParentObject;
    public enum Quest_Trigger_Type
    {
        START,
        SpawnEnemies,
        PlayCutscene,
        PlayDialogue,
        CollectPackage,
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
                mainQuest004Script.StartQuest();
                gameObject.transform.position = new Vector3(0, -500, 0);
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
                //n.a. in packages
            }

            if (TriggerType == Quest_Trigger_Type.CollectPackage)
            {
                ParentObject.SetActive(false);
                mainQuest004Script.packagesCollected++;

                if (mainQuest004Script.packagesCollected == 2)
                {
                    mainQuest004Script.PlayDialogue002();
                }

                if (mainQuest004Script.packagesCollected == 4)
                {
                    mainQuest004Script.PlayDialogue003();
                }

                if (mainQuest004Script.packagesCollected == 7)
                {
                    mainQuest004Script.PlayDialogue004();
                }

                if (mainQuest004Script.packagesCollected == 10)
                {
                    mainQuest004Script.PlayDialogue005();
                    mainQuest004Script.EndQuestTrigger.SetActive(true);
                }

                

            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                mainQuest004Script.PlayCutscene7();
            }
        }

            

    }
}
