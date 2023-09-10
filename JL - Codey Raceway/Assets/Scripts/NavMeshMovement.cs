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
    public Transform avatar;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        avatarPosition = gameObject.transform.position;

        for (int i = 0; i <= obstacles.Length; i++)
        {
            Vector3.Distance(avatarPosition, obstacles[i].transform.position);
        }

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
