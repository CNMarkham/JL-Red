using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;

    public CodeyMove CodeyMove;

    // Update is called once per frame
    void Update()
    {
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            CodeyMove.canMove = false;
        }
        if(totalCountdownTime <= 0)
        {
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            CodeyMove.canMove = true;
            startCountdown.enabled = false;
        }
        if(totalLapTime < 0)
        {
            print("Time is up!");
        }
        
    }
}
