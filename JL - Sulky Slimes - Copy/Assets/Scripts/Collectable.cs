using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    [Header("Movement Values")]
    public float distanceToMove;

    private Vector3 startingPosition;
    private Vector3 endingPosition;

    public float speed = 0.1f;
    public float direction = 1f;

    [Header("Scene to Load")]
    public int sceneNumber;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = gameObject.transform.position;
        endingPosition = new Vector3(startingPosition.x + distanceToMove, startingPosition.y, startingPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < startingPosition.x)
        {

            direction = 1f;
        }
        if (gameObject.transform.position.x > endingPosition.x)
        {
            direction = -1f;
        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * direction * Time.deltaTime, startingPosition.y, startingPosition.z);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("LoadNextScene", 2f);
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
