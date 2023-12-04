using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private KickingBall kickingBall;
    [SerializeField] private Goal goal;
    private int kicksCounter;
    [SerializeField] private int parLevel;
    [SerializeField] public GameObject completePanel;
    [SerializeField] public GameObject dialogBoxPanel;
    private LogFile log;
    private bool scored = false;
    private float timer = 3;
    private int index;

    void Start()
    {
        completePanel.SetActive(false);
        Scene scene = SceneManager.GetActiveScene();
        index = scene.buildIndex;
        log = gameObject.GetComponent<LogFile>();
        Log();
    }

    public void Log()
    {
        string userName = Environment.UserName;
        
        string host = Dns.GetHostName();
        IPAddress[] ip = Dns.GetHostEntry(host).AddressList;
        DateTime startingTime = DateTime.Now;
        DateTime exitTime = DateTime.Now;
        //log.WriteLine(userName, host, startingTime, exitTime);
    }

    public void StartTurn()
    {
        dialogBoxPanel.SetActive(false);
     }

    public void Retry()
    {
        SceneManager.LoadScene(index);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(index + 1);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(index - 2);
    }

    public void OpenCompletePanel()
    {
        scored = true;
    }

    public int KicksCounter
    {
        get { return kicksCounter; }
        set { kicksCounter = value; }
    }

    public int ParLevel
    {
        get { return parLevel; }
        set { parLevel = value; }
    }

    public int MapLevel
    {
        get { return index; }
        set { index = value; }
    }
    void Update()
    {
        kicksCounter = kickingBall.KickingBallCounter;
        if (scored)
        {
            if (timer > 0)
            {
                timer -= 1 * Time.deltaTime;
            }
            else
            {
                completePanel.SetActive(true);
                scored = false;
                timer = 3;
            }
        }
    }
}
