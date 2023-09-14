using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedBoost = 400;
    public GameObject avatar;


    // Start is called before the first frame update
    void Start()
    { 

        avatar.GetComponent<CodeyMove>().Speed += speedBoost;

        StartCoroutine(Speed());

    }


    IEnumerator Speed()
    {
        avatar.GetComponent<CodeyMove>().Speed -= speedBoost;
        yield return new WaitForSeconds(5);
    }
}
