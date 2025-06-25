using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject playButton;
    public Text highestScoreText;
    private int highestScore;

    public void addScore(int scoreToAdd)


    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;
        pause();

        highestScore = PlayerPrefs.GetInt("HighestScore", 0);
        highestScoreText.text = highestScore.ToString();

    }

    public void Play()
    {
        scoreText.text = playerScore.ToString();
        gameOverScreen.SetActive(false);
        playButton.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void pause()
    {
        Time.timeScale = 0f;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        playButton.SetActive(false);

        if (playerScore > highestScore)
        {
            highestScore = playerScore;
            PlayerPrefs.SetInt("HighestScore", highestScore);
            PlayerPrefs.Save();
        }
        highestScoreText.text = highestScore.ToString();
        pause();
    }

    public void Exit()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

}
