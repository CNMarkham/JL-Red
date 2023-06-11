using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Codey")
        {
            print("You Win!");
        }
    }
}
