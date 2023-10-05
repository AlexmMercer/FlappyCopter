using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DetectorScript : MonoBehaviour
{
    [SerializeField] GameManager Manager;
    [SerializeField] TextMeshProUGUI GameScoreText;
    [SerializeField] GameObject ScoreText;
    [SerializeField] ParticleSystem Explosion;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Building>(out var building))
        {
            Explosion.Play();
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Game over!");
            ScoreText.SetActive(false);
            Manager.ShowlevelCompletePanel();
            GameScoreText.text = $"Score: {Manager.PlayerScore}";
        } else if(other.gameObject.TryGetComponent<PointZone>(out var pointZone))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Passed!");
            Manager.PlayerScore++;
            ScoreText.GetComponent<TextMeshProUGUI>().text = $"{Manager.PlayerScore}";
        }
    }
}
