using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DetectorScript : MonoBehaviour
{
    [SerializeField] GameManager Manager;
    [SerializeField] TextMeshProUGUI GameScoreText;
    [SerializeField] TextMeshProUGUI ScoreText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Building>(out var building))
        {
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Game over!");
            Manager.ShowlevelCompletePanel();
            GameScoreText.text = $"Score: {Manager.PlayerScore}";
        } else if(other.gameObject.TryGetComponent<PointZone>(out var pointZone))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Passed!");
            Manager.PlayerScore++;
            ScoreText.text = $"{Manager.PlayerScore}";
        }
    }
}
