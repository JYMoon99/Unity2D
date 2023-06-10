using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int bestScore = 0;
    [SerializeField] Text bestScoreText;
    [SerializeField] Text currentScoreText;

    public int Score
    {
        set 
        { 
            score = value;

            
            currentScoreText.text = "Score : " + score;

        }
        get 
        {
            return score; 
        }
    }

    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        

        Load();

        Time.timeScale = 0f;

        bestScoreText.text = "BestScore : " + bestScore;
    }

    public void Ready()
    {
        var player = GameObject.Find("Player").GetComponent<Animator>();
        player.GetComponent<Animator>().updateMode = AnimatorUpdateMode.UnscaledTime;

        Time.timeScale = 1.0f;
    }
    public void Save()
    {
        if (bestScore <= score)
        {
            bestScore = score;

            PlayerPrefs.SetInt("BestScore", bestScore);
        }

    }

    public void Load()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
    }

    private void OnApplicationQuit() // 게임이 종료되었을때
    {
        Save();
    }
}
