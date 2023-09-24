using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedBoost = 400;
    public GameObject avatar;
    public CodeyMove codeyMove;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(avatar.GetComponent<CodeyMove>().Speed);
        //avatar.GetComponent<CodeyMove>().Speed += speedBoost;
        FindObjectOfType<CodeyMove>().Speed += speedBoost;
        // codeyMove.Speed += speedBoost;
        //Debug.Log(avatar.GetComponent<CodeyMove>().Speed);

        StartCoroutine(Speed());



    }


    IEnumerator Speed()
    {
        gameObject.transform.localScale = new Vector3(0,0,0);
        yield return new WaitForSeconds(5f);
        Debug.Log("slowing down");
        FindObjectOfType<CodeyMove>().Speed -= speedBoost;

    }
}