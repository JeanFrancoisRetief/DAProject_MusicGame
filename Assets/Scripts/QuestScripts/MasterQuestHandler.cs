using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterQuestHandler : MonoBehaviour
{
    [Header("Main Quest Scripts")]
    public MainQuest001 mainQuest001;
    public MainQuest002 mainQuest002;
    public MainQuest003 mainQuest003;
    public MainQuest004 mainQuest004;
    public MainQuest005 mainQuest005;

    [Header("Side Quest Scripts")]
    public SideQuest001 sideQuest001;
    public SideQuest002 sideQuest002;
    public SideQuest003 sideQuest003;
    public SideQuest004 sideQuest004;
    public SideQuest005 sideQuest005;

    [Header("Collectable Scripts")]
    public Collectables001 collectables001;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
