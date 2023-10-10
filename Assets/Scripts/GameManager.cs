using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int PlayerScore;
    public int PlayerHighScore;
    [SerializeField] GameObject LevelCompletePanel;

    void Start()
    {
        LevelCompletePanel.SetActive(false);

    }
    public void RestartLevel()
    {
        LevelCompletePanel.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowlevelCompletePanel()
    {
        LevelCompletePanel.SetActive(true);
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
    }
}
