using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public int timeLeft = 60;
    public Text time;
    public GameObject GameOverPanel;
    public GameObject backgroundPanel;

    // Use this for initialization
    void Start()
    {
        backgroundPanel.SetActive(true);
        GameOverPanel.SetActive(false);
        StartCoroutine("LoseTime");
        Time.timeScale = 1; // Just making sure that the timeScale is right
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            time.text = "Time: " + timeLeft;
        }
        if (timeLeft <= 0)
        {
            time.text = "Game Over";
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft == 0)
            {
                StopCoroutine("LoseTime");
                GameOverPanel.SetActive(true);
                backgroundPanel.SetActive(false);

                break;
            }
        }
    }
}
