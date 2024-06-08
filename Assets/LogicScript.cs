using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore; 
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public AudioSource scoredSFX;
    public AudioSource gameOverSFX;


   void Start()
    {
       
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreText();
    }



    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = "Score: " + playerScore.ToString();
       
        if (playerScore > highScore)
        {
            highScore = playerScore;
            UpdateHighScoreText();

            // Rekoru PlayerPrefs'e kaydet
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        scoredSFX.Play();
    }


    void UpdateHighScoreText()
    {
        highScoreText.text = "High Score: " + highScore.ToString();
    }





    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {

    gameOverScreen.SetActive(true);

        if (gameOverSFX != null)
    {
        gameOverSFX.Play();
    }
    else
    {
        Debug.LogError("gameOverSFX is not assigned!");
    }

    }



}