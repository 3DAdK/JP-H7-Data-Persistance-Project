using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text HighScoreText;

    private int m_HighScore;
    private string m_HighScoreName;

    void Start()
    {
        // Load saved data
        m_HighScore = PlayerPrefs.GetInt("HighScore", 0);
        m_HighScoreName = PlayerPrefs.GetString("HighScoreName", "Player");

        UpdateHighScoreText();
    }

    public void TrySetHighScore(int score)
    {
        string currentPlayer = PlayerPrefs.GetString("StoredText", "Player");

        if (score > m_HighScore)
        {
            m_HighScore = score;
            m_HighScoreName = currentPlayer;

            PlayerPrefs.SetInt("HighScore", m_HighScore);
            PlayerPrefs.SetString("HighScoreName", m_HighScoreName);
            PlayerPrefs.Save();

            UpdateHighScoreText();
        }
    }

    public void UpdateHighScoreText()
    {
        HighScoreText.text = $"Best: {m_HighScoreName} : {m_HighScore}";
    }

    // This is called during gameplay
    public void UpdateLive(int currentScore)
    {
        // Always show best score (even if not beaten yet)
        HighScoreText.text = $"Best: {m_HighScoreName} : {m_HighScore}";
    }
}
