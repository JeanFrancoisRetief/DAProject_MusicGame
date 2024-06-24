using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    [Header("Scripts")]
    public StateMachineScript stateMachineScript;
    public MusicCustomizationScript musicCustomizationScript;

    [Header("AudioSources")]
    public AudioSource Music_Walking_Default;
    public AudioSource Music_Walking_Western;
    public AudioSource Music_Walking_Classical;
    public AudioSource Music_Walking_Acoustic;
    public AudioSource Music_Walking_AIgenerated;
    public AudioSource Music_Walking_Retro;
    public AudioSource Music_Walking_AfricanLocal;

    public AudioSource Music_Running_Default;
    public AudioSource Music_Running_Western;
    public AudioSource Music_Running_Classical;
    public AudioSource Music_Running_Acoustic;
    public AudioSource Music_Running_AIgenerated;
    public AudioSource Music_Running_Retro;
    public AudioSource Music_Running_AfricanLocal;

    public AudioSource Music_Flying_Default;
    public AudioSource Music_Flying_Western;
    public AudioSource Music_Flying_Classical;
    public AudioSource Music_Flying_Acoustic;
    public AudioSource Music_Flying_AIgenerated;
    public AudioSource Music_Flying_Retro;
    public AudioSource Music_Flying_AfricanLocal;

    public AudioSource Music_COMBAT_Default;
    public AudioSource Music_COMBAT_Western;
    public AudioSource Music_COMBAT_Classical;
    public AudioSource Music_COMBAT_Acoustic;
    public AudioSource Music_COMBAT_AIgenerated;
    public AudioSource Music_COMBAT_Retro;
    public AudioSource Music_COMBAT_AfricanLocal;

    public AudioSource Music_WinScreen_Default;
    public AudioSource Music_WinScreen_Western;
    public AudioSource Music_WinScreen_Classical;
    public AudioSource Music_WinScreen_Acoustic;
    public AudioSource Music_WinScreen_AIgenerated;
    public AudioSource Music_WinScreen_Retro;
    public AudioSource Music_WinScreen_AfricanLocal;

    public AudioSource Music_DeathScreen_Default;
    public AudioSource Music_DeathScreen_Western;
    public AudioSource Music_DeathScreen_Classical;
    public AudioSource Music_DeathScreen_Acoustic;
    public AudioSource Music_DeathScreen_AIgenerated;
    public AudioSource Music_DeathScreen_Retro;
    public AudioSource Music_DeathScreen_AfricanLocal;

    public AudioSource Music_CUTSCENE_Default;
    public AudioSource Music_CUTSCENE_Western;
    public AudioSource Music_CUTSCENE_Classical;
    public AudioSource Music_CUTSCENE_Acoustic;
    public AudioSource Music_CUTSCENE_AIgenerated;
    public AudioSource Music_CUTSCENE_Retro;
    public AudioSource Music_CUTSCENE_AfricanLocal;

    /*
    public AudioSource Music__Default;
    public AudioSource Music__Western;
    public AudioSource Music__Classical;
    public AudioSource Music__Acoustic;
    public AudioSource Music__AIgenerated;
    public AudioSource Music__Retro;
    public AudioSource Music__AfricanLocal;
    */




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisableAllAudioSources();
        if (stateMachineScript.currentState == StateMachineScript.State.Walking)
        {
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Default)
            {
                Music_Walking_Default.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Western)
            {
                Music_Walking_Western.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Classical)
            {
                Music_Walking_Classical.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
            {
                Music_Walking_Acoustic.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
            {
                Music_Walking_AIgenerated.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Retro)
            {
                Music_Walking_Retro.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
            {
                Music_Walking_AfricanLocal.mute = false;
            }
        }
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            if (stateMachineScript.currentState == StateMachineScript.State.Running)
            {
                //Debug.Log("Is Walking");
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Default)
                {
                    Music_Running_Default.mute = false;
                }
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Western)
                {
                    Music_Running_Western.mute = false;
                }
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Classical)
                {
                    Music_Running_Classical.mute = false;
                }
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
                {
                    Music_Running_Acoustic.mute = false;
                }
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
                {
                    Music_Running_AIgenerated.mute = false;
                }
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Retro)
                {
                    Music_Running_Retro.mute = false;
                }
                if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
                {
                    Music_Running_AfricanLocal.mute = false;
                }
            }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (stateMachineScript.currentState == StateMachineScript.State.Flying)
        {
            //Debug.Log("Is Walking");
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Default)
            {
                Music_Flying_Default.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Western)
            {
                Music_Flying_Western.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Classical)
            {
                Music_Flying_Classical.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
            {
                Music_Flying_Acoustic.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
            {
                Music_Flying_AIgenerated.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.Retro)
            {
                Music_Flying_Retro.mute = false;
            }
            if (stateMachineScript.ExplorationMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
            {
                Music_Flying_AfricanLocal.mute = false;
            }
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (stateMachineScript.currentState == StateMachineScript.State.COMBAT)
        {
            //Debug.Log("Is Walking");
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Default)
            {
                Music_COMBAT_Default.mute = false;
            }
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Western)
            {
                Music_COMBAT_Western.mute = false;
            }
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Classical)
            {
                Music_COMBAT_Classical.mute = false;
            }
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
            {
                Music_COMBAT_Acoustic.mute = false;
            }
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
            {
                Music_COMBAT_AIgenerated.mute = false;
            }
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.Retro)
            {
                Music_COMBAT_Retro.mute = false;
            }
            if (stateMachineScript.CombatMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
            {
                Music_COMBAT_AfricanLocal.mute = false;
            }

        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (stateMachineScript.currentState == StateMachineScript.State.WinScreen)
        {
            //Debug.Log("Is Walking");
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Default)
            {
                Music_WinScreen_Default.mute = false;
            }
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Western)
            {
                Music_WinScreen_Western.mute = false;
            }
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Classical)
            {
                Music_WinScreen_Classical.mute = false;
            }
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
            {
                Music_WinScreen_Acoustic.mute = false;
            }
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
            {
                Music_WinScreen_AIgenerated.mute = false;
            }
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.Retro)
            {
                Music_WinScreen_Retro.mute = false;
            }
            if (stateMachineScript.VictoryMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
            {
                Music_WinScreen_AfricanLocal.mute = false;
            }

        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (stateMachineScript.currentState == StateMachineScript.State.DeathScreen)
        {
            //Debug.Log("Is Walking");
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Default)
            {
                Music_DeathScreen_Default.mute = false;
            }
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Western)
            {
                Music_DeathScreen_Western.mute = false;
            }
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Classical)
            {
                Music_DeathScreen_Classical.mute = false;
            }
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
            {
                Music_DeathScreen_Acoustic.mute = false;
            }
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
            {
                Music_DeathScreen_AIgenerated.mute = false;
            }
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.Retro)
            {
                Music_DeathScreen_Retro.mute = false;
            }
            if (stateMachineScript.DefeatMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
            {
                Music_DeathScreen_AfricanLocal.mute = false;
            }

        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        if (stateMachineScript.currentState == StateMachineScript.State.CUTSCENE)
        {
            //Debug.Log("Is Walking");
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Default)
            {
                Music_CUTSCENE_Default.mute = false;
            }
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Western)
            {
                Music_CUTSCENE_Western.mute = false;
            }
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Classical)
            {
                Music_CUTSCENE_Classical.mute = false;
            }
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Acoustic)
            {
                Music_CUTSCENE_Acoustic.mute = false;
            }
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.AIgenerated)
            {
                Music_CUTSCENE_AIgenerated.mute = false;
            }
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.Retro)
            {
                Music_CUTSCENE_Retro.mute = false;
            }
            if (stateMachineScript.NarrativeMusicTYPE == StateMachineScript.MusicTYPE.AfricanLocal)
            {
                Music_CUTSCENE_AfricanLocal.mute = false;
            }

        }



    } //update

    public void DisableAllAudioSources()
    {
        Music_Walking_Default.mute = true;
        Music_Walking_Western.mute = true;
        Music_Walking_Classical.mute = true;
        Music_Walking_Acoustic.mute = true;
        Music_Walking_AIgenerated.mute = true;
        Music_Walking_Retro.mute = true;
        Music_Walking_AfricanLocal.mute = true;

        Music_Running_Default.mute = true;
        Music_Running_Western.mute = true;
        Music_Running_Classical.mute = true;
        Music_Running_Acoustic.mute = true;
        Music_Running_AIgenerated.mute = true;
        Music_Running_Retro.mute = true; ;
        Music_Running_AfricanLocal.mute = true;

        Music_Flying_Default.mute = true;
        Music_Flying_Western.mute = true;
        Music_Flying_Classical.mute = true;
        Music_Flying_Acoustic.mute = true;
        Music_Flying_AIgenerated.mute = true;
        Music_Flying_Retro.mute = true;
        Music_Flying_AfricanLocal.mute = true;

        Music_COMBAT_Default.mute = true;
        Music_COMBAT_Western.mute = true;
        Music_COMBAT_Classical.mute = true;
        Music_COMBAT_Acoustic.mute = true;
        Music_COMBAT_AIgenerated.mute = true;
        Music_COMBAT_Retro.mute = true;
        Music_COMBAT_AfricanLocal.mute = true;

        Music_WinScreen_Default.mute = true;
        Music_WinScreen_Western.mute = true;
        Music_WinScreen_Classical.mute = true;
        Music_WinScreen_Acoustic.mute = true;
        Music_WinScreen_AIgenerated.mute = true;
        Music_WinScreen_Retro.mute = true;
        Music_WinScreen_AfricanLocal.mute = true;

        Music_DeathScreen_Default.mute = true;
        Music_DeathScreen_Western.mute = true;
        Music_DeathScreen_Classical.mute = true;
        Music_DeathScreen_Acoustic.mute = true;
        Music_DeathScreen_AIgenerated.mute = true;
        Music_DeathScreen_Retro.mute = true;
        Music_DeathScreen_AfricanLocal.mute = true;

        Music_CUTSCENE_Default.mute = true;
        Music_CUTSCENE_Western.mute = true;
        Music_CUTSCENE_Classical.mute = true;
        Music_CUTSCENE_Acoustic.mute = true;
        Music_CUTSCENE_AIgenerated.mute = true;
        Music_CUTSCENE_Retro.mute = true;
        Music_CUTSCENE_AfricanLocal.mute = true;
    }

}
