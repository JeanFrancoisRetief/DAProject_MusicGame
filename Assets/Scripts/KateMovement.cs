using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KateMovement : MonoBehaviour
{
    NavMeshAgent Kate;
    GameObject Player;
    public float distance;

    [Header("Quest 1")]
    public Transform Point001;
    public Transform Point002;
    public Transform Point003;

    public Transform destination;
    //private float distancePoint1;
    //private float distancePoint2;
    //private float distancePoint3;
    // Start is called before the first frame update
    void Start()
    {
        Kate = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("PlayerTarget");

        destination = Point001;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(Player.transform.position, transform.position);

        //distancePoint1 = Vector3.Distance(Point001.position, transform.position);
        //distancePoint2 = Vector3.Distance(Point002.position, transform.position);
        //distancePoint3 = Vector3.Distance(Point003.position, transform.position);

        

        if (distance < 20)
        {
            Kate.SetDestination(destination.position);
        }
        else
        {
            Kate.SetDestination(Kate.transform.position);
        }
    }

    
}
