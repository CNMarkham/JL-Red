using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.one, Time.deltaTime * 60f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Codey")
        {
            gameObject.SetActive(false);
            Invoke("BoxRespawn", 4f);
        }
    }

    void BoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
