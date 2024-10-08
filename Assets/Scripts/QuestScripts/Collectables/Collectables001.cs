using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables001 : MonoBehaviour
{                       
                                 // 0     1      2      3       4     5       6      7     8      9      10     11     12
    public bool[] collectables = { false, false, false, false, false, false, false, false, false, false, false, false, false };

    public GameObject[] menuItems;

    public GameObject ColectablePanel;

    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < collectables.Length; i++)
        {
            if (collectables[i] == true)
            {
                collectables[i] = false;
            }
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollectableMenuClick()
    {
        if (ColectablePanel.active == true)
        {
            ColectablePanel.SetActive(false);

        }
        else
        {
            ColectablePanel.SetActive(true);
            for (int i = 1; i < collectables.Length; i++)
            {
                if (collectables[i] == true)
                {
                    menuItems[i].SetActive(true);
                }
            }
        }

        
    }
}
