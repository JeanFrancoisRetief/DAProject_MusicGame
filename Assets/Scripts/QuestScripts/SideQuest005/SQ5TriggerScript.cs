using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQ5TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public SideQuest005 sideQuest005Script;
    [Header("ParentObject")]
    public GameObject ParentObject;

    public enum Quest_Trigger_Type
    {
        START,
        Enemy,
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
        if (other.tag == "Player")
        {
            if (TriggerType == Quest_Trigger_Type.START)
            {
                sideQuest005Script.StartQuest();
                gameObject.transform.position = new Vector3(0, -500, 0);
            }


            if (TriggerType == Quest_Trigger_Type.PlayCutscene)
            {
                //n.a.
            }

            if (TriggerType == Quest_Trigger_Type.PlayDialogue)
            {
                sideQuest005Script.PlayDialogue();
            }

            if (TriggerType == Quest_Trigger_Type.CollectPackages)
            {
                sideQuest005Script.PackageCollect();
                ParentObject.transform.position = new Vector3(ParentObject.transform.position.x, 400, ParentObject.transform.position.z);
            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                sideQuest005Script.EndQuest();
                gameObject.transform.position = new Vector3(0, -500, 0);
                gameObject.SetActive(false);
            }
        }

        if (other.tag == "MeleeAttack" || other.tag == "RangedAttack")
        {
            if (TriggerType == Quest_Trigger_Type.Enemy)
            {
                sideQuest005Script.QuestGiver.SetActive(false);
            }
        }
            

    }
}
