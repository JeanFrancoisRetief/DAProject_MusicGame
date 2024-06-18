using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineScript : MonoBehaviour
{
    public MusicCustomizationScript musicCustomizationScript;
    public enum State
    {
        Walking,
        Running,
        Flying,
        COMBAT,
        WinScreen,
        DeathScreen,
        CUTSCENE1, CUTSCENE2
    }

    public enum MusicTYPE
    {
        Default,
        Western,
        Classical,
        Acoustic,
        AIgenerated,
        Retro,
        AfricanLocal
    }

    public MusicTYPE ExplorationMusicTYPE;
    public MusicTYPE CombatMusicTYPE;
    public MusicTYPE VictoryMusicTYPE;
    public MusicTYPE DefeatMusicTYPE;
    public MusicTYPE NarrativeMusicTYPE;

    public State currentState;

    /*
    if (currentState == State.Walking)
    {
        if(ExplorationMusicTYPE ==  MusicTYPE.Default)
        {
            AudioSource.....
        }
        if(ExplorationMusicTYPE ==  MusicTYPE.Western)
        {

        }
        //etc.

    }

     */


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ExplorationMusicTYPE + " " + CombatMusicTYPE + " " + VictoryMusicTYPE + " " + DefeatMusicTYPE + " " + NarrativeMusicTYPE);


    }
}
