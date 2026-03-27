using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text HighScoreText;
    private int m_HighScore;

    void Start()
    {
        // Load high score (default = 0)
        m_HighScore = PlayerPrefs.GetInt("HighScore", 0);

        UpdateHighScoreText();
    }

    public void TrySetHighScore(int score)
    {
        if (score > m_HighScore)
        {
            m_HighScore = score;

            // Save new high score
            PlayerPrefs.SetInt("HighScore", m_HighScore);
            PlayerPrefs.Save();

            UpdateHighScoreText();
        }
    }

    void UpdateHighScoreText()
    {
        string playerName = PlayerPrefs.GetString("StoredText", "Player");
        HighScoreText.text = $"{playerName} High Score: {m_HighScore}";
    }
}
