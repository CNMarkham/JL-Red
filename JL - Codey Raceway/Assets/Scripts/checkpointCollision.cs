using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointCollision : MonoBehaviour
{

    public CheckpointCounter count;
    public bool didCollide;

    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey" && didCollide == false)
        {
            didCollide = true;
            count.triggeredCheckPoints++;

        }
    }
}
