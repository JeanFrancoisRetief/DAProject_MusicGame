using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C1TriggerScript : MonoBehaviour
{
    public GameObject CollectableUICanvas;
    public Transform TargetCam;

    public GameObject ParentCollectableObj;

    

    [Header("Corresponding Script")]
    public Collectables001 Collectables001Script;

    [Header("Images")]
    public GameObject[] images;
    /*public GameObject img001;
    public GameObject img002;
    public GameObject img003;
    public GameObject img004;
    public GameObject img005;
    public GameObject img006;
    public GameObject img007;
    public GameObject img008;
    public GameObject img009;
    public GameObject img010;
    public GameObject img011;
    public GameObject img012;*/

    [Header("SET INDEX")]
    public int CollectableIndex;




    // Start is called before the first frame update
    void Start()
    {
        images[CollectableIndex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        CollectableUICanvas.transform.LookAt(TargetCam);
    }

    private void OnTriggerEnter(Collider other)
    {
        Collectables001Script.collectables[CollectableIndex] = true;
        Collectables001Script.collectableCount++;

        ParentCollectableObj.SetActive(false);
    }
}
