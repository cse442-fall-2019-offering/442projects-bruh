using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class GameCountdown : MonoBehaviour
{
    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object
    public GameObject GameOverPanel;
    public GameObject backgroundPanel;
    void Start()
    {
        GameOverPanel.SetActive(false);
        StartCoroutine("DecTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }
    void Update()
    {
        if (timeLeft != 0)
        {
            countdown.text = ("Time Left:" + timeLeft); //Showing the Time on the Canvas
        }
        else
        {
            countdown.text = "Time Left:0";
        }
    }
    //Simple Coroutine
    IEnumerator DecTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
            if (timeLeft == 0)
            {
                StopCoroutine("DecTime");
                GameOverPanel.SetActive(true);
                backgroundPanel.SetActive(false);

                break;
            }
        }

    }
}