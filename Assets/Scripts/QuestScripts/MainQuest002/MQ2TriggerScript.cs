using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MQ2TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public MainQuest002 mainQuest002Script;
    [Header("ParentObject")]
    public GameObject ParentObject;

    public enum Quest_Trigger_Type
    {
        START,
        SpawnEnemies,
        PlayCutscene,
        PlayDialogue,
        CollectPackages,
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
                mainQuest002Script.StartQuest();
                //gameObject.SetActive(false);

            }

            if (TriggerType == Quest_Trigger_Type.SpawnEnemies)
            {

            }

            if (TriggerType == Quest_Trigger_Type.PlayCutscene)
            {
                //n.a. at end of quest
            }

            if (TriggerType == Quest_Trigger_Type.PlayDialogue)
            {
                mainQuest002Script.PlayDialogue();
            }

            if (TriggerType == Quest_Trigger_Type.CollectPackages)
            {
                mainQuest002Script.PackageCollect();
                ParentObject.SetActive(false);
            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                mainQuest002Script.PlayCutscene3();
                //mainQuest002Script.EndQuest();
                gameObject.transform.position = new Vector3(0, -500, 0);
                gameObject.SetActive(false);
            }
        }
        

    }
}
