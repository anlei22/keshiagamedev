using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private float score;
    private int highScore;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    void Update()
    {
        if (player != null)
        {
            score += Time.deltaTime;
            scoreText.text = ((int)score).ToString();

            if ((int)score > highScore)
            {
                highScore = (int)score;
                PlayerPrefs.SetInt("HighScore", highScore);
                highScoreText.text = "High Score: " + highScore.ToString();
            }
        }
    }
}
    