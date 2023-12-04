using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Button startButton;
    [SerializeField] private Button retryButton;
    [SerializeField] private Button nextLevelButton;
    [SerializeField] private Button resetGameButton;
    [SerializeField] private TextMeshProUGUI mapLevel;
    [SerializeField] private TextMeshProUGUI par;
    [SerializeField] private TextMeshProUGUI kicksCount;
    [SerializeField] private TextMeshProUGUI mapLevelPanel2;
    [SerializeField] private TextMeshProUGUI finalKicksCount;
    [SerializeField] private TextMeshProUGUI outcome;
    private int total;
    void Awake()
    {
        var start = GameObject.Find("Start");
        startButton = start.GetComponent<Button>();
        startButton.onClick.AddListener(gameManager.StartTurn);

        var retry = GameObject.Find("Retry");
        retryButton = retry.GetComponent<Button>();
        retryButton.onClick.AddListener(gameManager.Retry);

        var nextLevel = GameObject.Find("NextLevel");
        nextLevelButton = nextLevel.GetComponent<Button>();
        nextLevelButton.onClick.AddListener(gameManager.NextLevel);

        var resetGame = GameObject.Find("ResetGame");
        resetGameButton = resetGame.GetComponent<Button>();
        resetGameButton.onClick.AddListener(gameManager.ResetGame);

    }
    
    void Update()
    {
        int mapLevelIndex = gameManager.MapLevel;
        int kicksCounter = gameManager.KicksCounter;
        int parLevel = gameManager.ParLevel;

        mapLevel.text = string.Format("Level {0}", mapLevelIndex+1);
        par.text = string.Format("Par {0}", parLevel);
        kicksCount.text = string.Format("Kicks: {0} / {1}", kicksCounter, parLevel);
        mapLevelPanel2.text = string.Format("Level {0} complete", mapLevelIndex + 1);
        finalKicksCount.text = string.Format("Kicks {0} / Par {1}", kicksCounter, parLevel);
        total = kicksCounter - parLevel;
        if(kicksCounter > parLevel)
        {
            outcome.text = string.Format("Total: {0} over par", Mathf.Abs(total));
        } else
        {
            outcome.text = string.Format("Total: {0} under par", Mathf.Abs(total));
        }
    }
}
