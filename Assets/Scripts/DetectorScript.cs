using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public GameManager manager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Building"))
        {
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Time.timeScale = 0.0f;
            Debug.Log("Game over!");
            manager.ShowlevelCompletePanel();
            manager.gameScoreText.text = $"Score: {manager.playerScore}";
        } else if(other.gameObject.CompareTag("Checkpoint"))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Passed!");
            manager.playerScore++;
            manager.scoreText.text = $"{manager.playerScore}";
        }
    }
}
