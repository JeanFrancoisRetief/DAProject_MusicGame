using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MusicTextFileCreate : MonoBehaviour
{
    public StreamWriter sw;
    public StateMachineScript stateMachineScript;


    // Start is called before the first frame update
    void Start()
    {
        CreateTextFile();
    }

    // Update is called once per frame
    void Update()
    {
        WriteToTextFile();
    }

    public void CreateTextFile()
    {
        using (sw = new StreamWriter(Application.dataPath + "/MusicData.txt", true))
        {
            sw.WriteLine("Durring the course of the playthrough, this is what the player chose:");
            sw.WriteLine("Exploration, Combat, Victory, Defeat, Cutscenes");
        }
    }

    public void WriteToTextFile()
    {
        //Debug.Log(ExplorationMusicTYPE + " " + CombatMusicTYPE + " " + VictoryMusicTYPE + " " + DefeatMusicTYPE + " " + NarrativeMusicTYPE);
        using (sw)
        {
            sw.WriteLine(stateMachineScript.ExplorationMusicTYPE + " " + stateMachineScript.CombatMusicTYPE + " " + stateMachineScript.VictoryMusicTYPE + " " + stateMachineScript.DefeatMusicTYPE + " " + stateMachineScript.NarrativeMusicTYPE);
        }
    }
}
