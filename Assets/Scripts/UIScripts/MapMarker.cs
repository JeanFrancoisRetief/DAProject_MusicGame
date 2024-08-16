using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMarker : MonoBehaviour
{
    
    public QuestType thisQuestType;

    public GameObject MainMarker;
    public GameObject SideMarker;

    public enum QuestType
    {
        Main,
        Side
    }

    // Start is called before the first frame update
    void Start()
    {
        if(thisQuestType == QuestType.Main)
        {
            MainMarker.SetActive(true);
        }
        else
        {
            SideMarker.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
