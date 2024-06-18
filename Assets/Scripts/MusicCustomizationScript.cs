using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicCustomizationScript : MonoBehaviour
{
    [Header("DropdownMenus")]
    public TMP_Dropdown PresetDropDown; 
    public TMP_Dropdown ExplorationDropDown;
    public TMP_Dropdown CombatDropDown;
    public TMP_Dropdown VictoryDropDown;
    public TMP_Dropdown DefeatDropDown;
    public TMP_Dropdown NarrativeDropDown;

    [Header("Panels")]
    public GameObject BlockPanel;

    [Header("Scripts")]
    public StateMachineScript stateMachineScript;

    // Start is called before the first frame update
    void Start()
    {
        BlockPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(stateMachineScript.ExplorationMusicTYPE);
        
    }

    #region OnChangeEvents

    public void OnPresetChange()
    {
        if (PresetDropDown.value == 7)
        {
            BlockPanel.SetActive(false);
        }
        else
        {
            BlockPanel.SetActive(true);
            ExplorationDropDown.value = PresetDropDown.value;
            CombatDropDown.value = PresetDropDown.value;
            VictoryDropDown.value = PresetDropDown.value;
            DefeatDropDown.value = PresetDropDown.value;
            NarrativeDropDown.value = PresetDropDown.value;
        }
    }

    public void OnExplorationChange()
    {
        if (ExplorationDropDown.value == 0)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.Default;
        }
        else if (ExplorationDropDown.value == 1)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.Western;
        }
        else if (ExplorationDropDown.value == 2)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.Classical;
        }
        else if (ExplorationDropDown.value == 3)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.Acoustic;
        }
        else if (ExplorationDropDown.value == 4)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.AIgenerated;
        }
        else if (ExplorationDropDown.value == 5)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.Retro;
        }
        else if (ExplorationDropDown.value == 6)
        {
            stateMachineScript.ExplorationMusicTYPE = StateMachineScript.MusicTYPE.AfricanLocal;
        }

    }

    public void OnCombatChange()
    {
        if (CombatDropDown.value == 0)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.Default;
        }
        else if (CombatDropDown.value == 1)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.Western;
        }
        else if (CombatDropDown.value == 2)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.Classical;
        }
        else if (CombatDropDown.value == 3)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.Acoustic;
        }
        else if (CombatDropDown.value == 4)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.AIgenerated;
        }
        else if (CombatDropDown.value == 5)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.Retro;
        }
        else if (CombatDropDown.value == 6)
        {
            stateMachineScript.CombatMusicTYPE = StateMachineScript.MusicTYPE.AfricanLocal;
        }
    }

    public void OnVictoryChange()
    {
        if (VictoryDropDown.value == 0)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.Default;
        }
        else if (VictoryDropDown.value == 1)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.Western;
        }
        else if (VictoryDropDown.value == 2)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.Classical;
        }
        else if (VictoryDropDown.value == 3)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.Acoustic;
        }
        else if (VictoryDropDown.value == 4)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.AIgenerated;
        }
        else if (VictoryDropDown.value == 5)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.Retro;
        }
        else if (VictoryDropDown.value == 6)
        {
            stateMachineScript.VictoryMusicTYPE = StateMachineScript.MusicTYPE.AfricanLocal;
        }
    }

    public void OnDefeatChange()
    {
        if (DefeatDropDown.value == 0)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.Default;
        }
        else if (DefeatDropDown.value == 1)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.Western;
        }
        else if (DefeatDropDown.value == 2)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.Classical;
        }
        else if (DefeatDropDown.value == 3)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.Acoustic;
        }
        else if (DefeatDropDown.value == 4)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.AIgenerated;
        }
        else if (DefeatDropDown.value == 5)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.Retro;
        }
        else if (DefeatDropDown.value == 6)
        {
            stateMachineScript.DefeatMusicTYPE = StateMachineScript.MusicTYPE.AfricanLocal;
        }
    }

    public void OnNarrativeChange()
    {
        if (NarrativeDropDown.value == 0)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.Default;
        }
        else if (NarrativeDropDown.value == 1)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.Western;
        }
        else if (NarrativeDropDown.value == 2)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.Classical;
        }
        else if (NarrativeDropDown.value == 3)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.Acoustic;
        }
        else if (NarrativeDropDown.value == 4)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.AIgenerated;
        }
        else if (NarrativeDropDown.value == 5)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.Retro;
        }
        else if (NarrativeDropDown.value == 6)
        {
            stateMachineScript.NarrativeMusicTYPE = StateMachineScript.MusicTYPE.AfricanLocal;
        }
    }


    #endregion
}
