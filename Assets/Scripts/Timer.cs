using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        StartStopwatch();
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:ff");
    }

    public void StartStopwatch() { 
        stopwatchActive = true; 
    }

    public void StopStopwatch() {
        stopwatchActive = false;
    }
}
