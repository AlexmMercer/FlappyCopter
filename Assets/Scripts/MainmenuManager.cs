using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuManager : MonoBehaviour
{
    [SerializeField] GameObject ShowPanel;

    private void Start()
    {
        ShowPanel.SetActive(false);
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShowHint()
    {
        ShowPanel.SetActive(true);
    }

    public void CloseHint()
    {
        ShowPanel.SetActive(false);
    }
}
