using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    private float score;
    private float scoreMultiplier = 5;
    public const string highScoreKey = "HighScore";
    void Start()
    {
        
    }

    void Update()
    {
        score += scoreMultiplier * Time.deltaTime;
        scoreText.text = score.ToString("F0");
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(highScoreKey, 0);
        if(score >= currentHighScore)
        {
            PlayerPrefs.SetInt(highScoreKey, Mathf.FloorToInt(score));
        }
    }
}
