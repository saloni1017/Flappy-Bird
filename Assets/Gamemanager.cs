using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public int PlayerScore = 0;
    public GameObject GameOver;

    [ContextMenu("Increase score")]
    public void AddScore()
    {
        PlayerScore += 1;
        Score.text = PlayerScore.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void GameOverActive()
    {
        GameOver.SetActive(true);
    }
}
