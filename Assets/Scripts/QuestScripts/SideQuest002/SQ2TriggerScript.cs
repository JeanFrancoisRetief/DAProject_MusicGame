using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQ2TriggerScript : MonoBehaviour
{
    [Header("Please select Quest Trigger Type")]
    public Quest_Trigger_Type TriggerType;
    [Header("Corresponding Script")]
    public SideQuest002 sideQuest002Script;

    public enum Quest_Trigger_Type
    {
        START,
        Member818,
        Member828,
        Member838,
        Member848,
        Member858,
        Member868,
        Member878,
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
                sideQuest002Script.StartQuest();
            }

            if (TriggerType == Quest_Trigger_Type.Member818)
            {
                sideQuest002Script.InteractWith818();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Default)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }
            }

            if (TriggerType == Quest_Trigger_Type.Member828)
            {
                sideQuest002Script.InteractWith828();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Western)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }
            }

            if (TriggerType == Quest_Trigger_Type.Member838)
            {
                sideQuest002Script.InteractWith838();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Classical)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }

            }
            if (TriggerType == Quest_Trigger_Type.Member848)
            {
                sideQuest002Script.InteractWith848();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Retro)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }

            }

            if (TriggerType == Quest_Trigger_Type.Member858)
            {
                sideQuest002Script.InteractWith858();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }

            }

            if (TriggerType == Quest_Trigger_Type.Member868)
            {
                sideQuest002Script.InteractWith868();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }

            }

            if (TriggerType == Quest_Trigger_Type.Member878)
            {
                sideQuest002Script.InteractWith878();
                //Remove trigger if succeeded
                if (sideQuest002Script.stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
                {
                    gameObject.transform.position = new Vector3(0, -500, 0);
                }

            }

            if (TriggerType == Quest_Trigger_Type.END)
            {
                sideQuest002Script.EndOfQuestDialogue();//invokes endquest
            }
        }

            

    }
}
