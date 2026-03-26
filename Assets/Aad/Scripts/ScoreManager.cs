using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    public TMP_Text HighScoreText;

    private int m_Points;
    private int highScore;
    private string highScoreName;

    void Start()
    {
        // Load saved high score + name
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreName = PlayerPrefs.GetString("HighScoreName", "None");

        HighScoreText.text = $"High Score: {highScoreName} - {highScore}";
    }

    public void AddPoint(int point)
    {
        m_Points += point;

        string playerName = PlayerPrefs.GetString("StoredText", "Player");

        // Update current score
        ScoreText.text = $"{playerName} Score: {m_Points}";

        // Check if new high score
        if (m_Points > highScore)
        {
            highScore = m_Points;
            highScoreName = playerName;

            // Save BOTH name and score
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.SetString("HighScoreName", highScoreName);
            PlayerPrefs.Save();

            HighScoreText.text = $"High Score: {highScoreName} - {highScore}";
        }
    }
}
