using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerss : MonoBehaviour
{

    public float timeStart = 3f;
    public Text timer;

    private void Start()
    {
        timer.text = timeStart.ToString();
        Time.timeScale = 0f;
    }
    private void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            timer.text = Mathf.Round(timeStart).ToString();
        }
        else
        {
            Destroy(timer);
        }
        
    }
}
