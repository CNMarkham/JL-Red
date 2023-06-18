using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCounter : MonoBehaviour
{

    public int numberOfCheckpoints;
    public int triggeredCheckPoints;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }
}
