using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{
    public GameObject NonStartMenu;
    public GameObject MusicCanvas;

    public MasterQuestHandler masterQuestHandler;
    private void Start()
    {
        QualitySettings.vSyncCount = 0;  // VSync must be disabled
        Application.targetFrameRate = 60;//lock frame rate;

        NonStartMenu.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        //simple "Press esc key" then exit program - so as not to use task manager to end program
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.Quit();
            NonStartMenu.SetActive(true);
        }

        if(MusicCanvas.active == true)
        {
            NonStartMenu.SetActive(false);
        }

    }

    //Buttons
    public void OnResumeClick()
    {
        NonStartMenu.SetActive(false);
        
    }

    public void OnMusicSettingsClick()
    {
        MusicCanvas.SetActive(true);
    }

    public void OnSaveClick()
    {
        masterQuestHandler.SaveQuests();
    }

    public void OnQuitGameClick()
    {
        masterQuestHandler.SaveQuests();
        Application.Quit();
    }

    
}
