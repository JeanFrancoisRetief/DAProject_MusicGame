using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KateTriggers : MonoBehaviour
{
    public KateMovement kateMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (gameObject.tag == "MQ1Point1")
            {
                kateMovement.destination = kateMovement.Point002;
                gameObject.SetActive(false);
            }
            if (gameObject.tag == "MQ1Point2")
            {
                kateMovement.destination = kateMovement.Point003;
                gameObject.SetActive(false);
            }
            if (gameObject.tag == "MQ1Point3")
            {
                kateMovement.isAtEnd = true;
            }
        }
        

    }
}
