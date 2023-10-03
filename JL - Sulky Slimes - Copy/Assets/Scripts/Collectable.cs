using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = 1f;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = gameObject.transform.position;
        endingPosition = new Vector3(startingPosition.x + distanceToMove, startingPosition.y, startingPosition.z); 
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < startingPosition.x)
        {
            direction = 1f;
        } 
        if(gameObject.transform.position.x > endingPosition.x)
        {
            direction = -1f;
        }
    }
}
