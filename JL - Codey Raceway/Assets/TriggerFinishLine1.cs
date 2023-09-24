using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerFinishLine1 : MonoBehaviour
{

    public CheckpointCounter checkpointTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey")
        {
            if (checkpointTracker.triggeredCheckPoints == checkpointTracker.numberOfCheckpoints)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                print("Cheater!");
            }
        }
    }
}
