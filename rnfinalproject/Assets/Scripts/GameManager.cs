using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI GameOverText;
    public TextMeshProUGUI Title;
    public Button restartButton;
    public Button startButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = 0;
        UpdateCount(0);
        GameOverText.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(false);
        Title.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        startButton.gameObject.SetActive(false);
        Title.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    public void UpdateCount(int countAdd)
    {
        count += countAdd;
        countText.text = "Marbles: " + count;
    }

    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        GameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
