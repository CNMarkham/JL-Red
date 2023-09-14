using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public GameObject [] obstacles;
    public Transform goal;
    private NavMeshAgent agent;
    public Vector3 avatarPosition;
    public GameObject avatar;
    public float smallestDistance = 1000;
    public GameObject closestDistance;
    public float Distance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        avatarPosition = avatar.transform.position;

        for (int i = 0; i < obstacles.Length; i++)
        {
            Distance = Mathf.Abs(Vector3.Distance(avatarPosition, obstacles[i].transform.position));
            if (Distance < smallestDistance)
            {

                smallestDistance = Distance;
                closestDistance = obstacles[i];
            }
            
        }

        goal = closestDistance.transform;
        agent.destination = goal.position;
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }
}
