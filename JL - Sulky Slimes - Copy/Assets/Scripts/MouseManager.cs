using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;
    
    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;
    public Vector3 slimeOriginalTransform;
    public Quaternion slimeOriginalRotation;

    [Header("Lives")]
    public LivesManager livesManager;

    // Start is called before the first frame update
    void Start()
    {
        slimeOriginalTransform = slimeTransform.position;
        slimeOriginalRotation = slimeTransform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(livesManager.lives <= 0)
        {
            SceneManager.LoadScene(0);
            return;
        }

        if(Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f, 
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
            );
            slimeTransform.position = slimeOriginalTransform - launchVector / 400;
            launchVector.Normalize();
        }
        if (Input.GetMouseButtonUp(0))
        {
            slimeRigidbody.isKinematic = false;
            slimeRigidbody.AddForce(launchVector * launchForce, ForceMode.Impulse);
        }
        if(Input.GetMouseButtonDown(1)||Input.GetKeyDown("space"))
        {
            slimeTransform.position = slimeOriginalTransform;
            slimeTransform.rotation = slimeOriginalRotation;
            slimeRigidbody.isKinematic = true;
            livesManager.RemoveLife();
        }
    }
}
