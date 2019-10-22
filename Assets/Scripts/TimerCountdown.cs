using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class TimerCountdown : MonoBehaviour
{
    public int timeLeft = 5; //Seconds Overall
    public int gameTimeLeft = 60;
    public Text countdown; //UI Text Object
    public Text gameCountdown;
    public GameObject timePanel;
    public GameObject backgroundPanel;
    public GameObject gameOverPanel;
    public void  TimeStart()
    {
        timePanel.SetActive(true);
        backgroundPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }
    void Update()
    {
        if (timeLeft != 0)
        {
            countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
        }
        else
        {
            countdown.text = "";
            if (gameTimeLeft != 0)
            {
                gameCountdown.text = ("Time Left:" + gameTimeLeft); //Showing the Score on the Canvas
            }
            else
            {
                gameCountdown.text = "Time Left:0";
            }
        }
        

    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if(timeLeft == 0)
            {
                StopCoroutine("LoseTime");
                timePanel.SetActive(false);
                backgroundPanel.SetActive(true);
                
                break;
            }
        }
        StartCoroutine("DecTime");
    }
    IEnumerator DecTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            gameTimeLeft--;
            if (gameTimeLeft == 0)
            {
                StopCoroutine("DecTime");
                gameOverPanel.SetActive(true);
                backgroundPanel.SetActive(false);

                break;
            }
        }

    }
}