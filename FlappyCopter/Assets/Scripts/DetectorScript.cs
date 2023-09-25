using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Environment"))
        {
            Destroy(gameObject);
            Time.timeScale = 0.0f;
            Debug.Log("Game over!");
            manager.ShowlevelCompletePanel();
            manager.gameScoreText.text = $"Score: {manager.playerScore}";
        } else if(other.gameObject.CompareTag("Checkpoint"))
        {
            Debug.Log("Passed!");
            manager.playerScore++;
            manager.scoreText.text = $"{manager.playerScore}";
        }
    }
}
