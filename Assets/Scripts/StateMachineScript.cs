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
        CUTSCENE
    }

    public enum MusicTYPE
    {
        Default, //orchestral
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

    public GameObject Player;
    public GameObject WinScreenPanel;
    public GameObject DeathScreenPanel;

    public bool inCombat;
    public bool inCutscene;



    // Start is called before the first frame update
    void Start()
    {
        inCombat = false;
        inCutscene = false;
        WinScreenPanel.SetActive(false);
        DeathScreenPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ExplorationMusicTYPE + " " + CombatMusicTYPE + " " + VictoryMusicTYPE + " " + DefeatMusicTYPE + " " + NarrativeMusicTYPE);

        CheckIfInCombat();
        CheckIfInCutscene();


        if (inCutscene)
        {
            currentState = State.CUTSCENE;
        }
        else if (DeathScreenPanel.active == true)
        {
            currentState = State.DeathScreen;
        }
        else if (WinScreenPanel.active == true)
        {
            currentState = State.WinScreen;
        }
        else if(inCombat)
        {
            currentState = State.COMBAT;
        }
        else if(Player.transform.position.y >= 10)  ///player way above the ground  -can use RAYCAST instead
        {
            currentState = State.Flying;
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            currentState = State.Running;
        }
        else
        {
            currentState = State.Walking;
        }


    }

    public void CheckIfInCombat()
    {

    }

    public void CheckIfInCutscene()
    {

    }
}
