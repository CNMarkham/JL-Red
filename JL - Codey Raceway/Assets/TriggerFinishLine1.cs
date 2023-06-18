using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine1 : MonoBehaviour
{

    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey")
        {
            if (checkpointTracker.triggeredCheckPoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
            }
            else
            {
                print("Cheater!");
            }
        }
    }
}
