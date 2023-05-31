using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score;
    [SerializeField] Text scoreText;

    public int Score
    {
        set 
        { 
            score = value;
            scoreText.text = "Score : " + Score;
        }
        get { return score; }
    }

    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

}
