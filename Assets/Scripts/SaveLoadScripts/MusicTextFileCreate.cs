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
        //CreateTextFile();

        Directory.CreateDirectory(Application.streamingAssetsPath + "/Music_Logs/");
    }

    // Update is called once per frame
    void Update()
    {
        //WriteToTextFile();
    }

    public void CreateOrWriteTextFile()
    {
        /*using (sw = new StreamWriter(Application.dataPath + "/MusicData.txt", true))
        {
            sw.WriteLine("Durring the course of the playthrough, this is what the player chose:");
            sw.WriteLine("Exploration, Combat, Victory, Defeat, Cutscenes");
        }*/

        string txtDocName = Application.streamingAssetsPath + "/Music_Logs/" + "MusicData" + ".txt";

        if(!File.Exists(txtDocName))
        {
            File.WriteAllText(txtDocName, "--------MUSIC LOG--------\n\nOrder: Exploration, Combat, Victory, Defeat, Cutscenes\n\n");
        }

        File.AppendAllText(txtDocName, System.DateTime.Now + " - "+ stateMachineScript.ExplorationMusicTYPE + " " + stateMachineScript.CombatMusicTYPE + " " + stateMachineScript.VictoryMusicTYPE + " " + stateMachineScript.DefeatMusicTYPE + " " + stateMachineScript.NarrativeMusicTYPE + "\n");


    }

    public void WriteToTextFile()
    {
        //Debug.Log(ExplorationMusicTYPE + " " + CombatMusicTYPE + " " + VictoryMusicTYPE + " " + DefeatMusicTYPE + " " + NarrativeMusicTYPE);
        /*using (sw)
        {
            sw.WriteLine(stateMachineScript.ExplorationMusicTYPE + " " + stateMachineScript.CombatMusicTYPE + " " + stateMachineScript.VictoryMusicTYPE + " " + stateMachineScript.DefeatMusicTYPE + " " + stateMachineScript.NarrativeMusicTYPE);
        }*/
    }
}
