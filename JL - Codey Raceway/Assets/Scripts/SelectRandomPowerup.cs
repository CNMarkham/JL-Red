using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{

    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        if(chosenPowerup && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(chosenPowerup, transform.position + new Vector3(4, 0, 0), transform.rotation);
            chosenPowerup = null;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
