using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float TimeRemaining = 60;

    public bool TimerIsRunning = false;
   
    public Text timeText;


    // Start is called before the first frame update
    void Start()
    {
        // Le timer commence 
        TimerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerIsRunning)
        {

           

            if (TimeRemaining > 0)
            {
                TimeRemaining -= Time.deltaTime;
                DisplayTime(TimeRemaining);
            }

            else
            {
                SceneManager.LoadScene("Menu");
                TimeRemaining = 0;
                TimerIsRunning = false;
            }
        }
    }


    // Montrer le temps en minute et secondes 
    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt (timeToDisplay / 60);

        float seconds = Mathf.FloorToInt (timeToDisplay % 60);

        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
    
}
