using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameScoreText;
    public GameObject levelCompletePanel;
    public TextMeshProUGUI finalScoreText;
    public Button restartLevelButton;
    void Start()
    {
        levelCompletePanel.SetActive(false);
        if(Time.timeScale == 0.0f) Time.timeScale = 1.0f;
        Debug.Log(Time.timeScale);
        //restartLevelButton.onClick.AddListener(RestartLevel);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartLevel()
    {
        levelCompletePanel.SetActive(false);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowlevelCompletePanel()
    {
        levelCompletePanel.SetActive(true);
        Time.timeScale = 1.0f;
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
        Time.timeScale = 1.0f;
        Debug.Log(Time.timeScale);
    }
}
