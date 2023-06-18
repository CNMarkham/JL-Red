using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{

    public GameObject itemBox;

    public int numberofBoxes;

    public int modifyXPosition;
    public int modifyZPosition;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberofBoxes; i++)
        {
            GameObject itemBoxClone = Instantiate(itemBox,
                new Vector3(transform.position.x + modifyXPosition * i, transform.position.y, transform.position.z + modifyZPosition * i), transform.rotation);
        }
    }
}
// for glitch where when the avatar hits an object, it absorbs that objects rotation, freezing the avatar's rotation's fixed the problem.