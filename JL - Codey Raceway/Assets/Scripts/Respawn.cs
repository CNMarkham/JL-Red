using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "terrain")
        {
            SceneManager.LoadScene(0);
        }
    }
}
