using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public GameManager Manager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Building"))
        {
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Game over!");
            Manager.ShowlevelCompletePanel();
            Manager.GameScoreText.text = $"Score: {Manager.PlayerScore}";
        } else if(other.gameObject.CompareTag("Checkpoint"))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Passed!");
            Manager.PlayerScore++;
            Manager.ScoreText.text = $"{Manager.PlayerScore}";
        }
    }
}
