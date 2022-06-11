using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    
    public Text scoreText;
    public Text highScoreText;

    int _score     = 0;
    int _highScore = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        scoreText.text     = _score.ToString() + " POINTS";
        highScoreText.text = "HIGHSCORE: " + _highScore.ToString();
        _highScore = PlayerPrefs.GetInt("HIGHSCORE:", 0);
    }

    public void AddPoint()
    {
        _score += 1;
        scoreText.text = _score.ToString() + " POINTS";
        if(_highScore < _score)
            PlayerPrefs.SetInt("HIGHSCORE", _score);
    }
}
