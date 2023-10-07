using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DetectorScript : MonoBehaviour
{
    [SerializeField] GameManager Manager;
    [SerializeField] TextMeshProUGUI GameScoreText;
    [SerializeField] TextMeshProUGUI HighScoreText;
    [SerializeField] GameObject ScoreText;
    [SerializeField] ParticleSystem ExplosionEffect;


    private void Start()
    {
        Manager.PlayerHighScore = PlayerPrefs.GetInt("Manager.PlayerHighScore", 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Building>(out var building))
        {
            Instantiate(ExplosionEffect, transform.position,
                        Quaternion.identity);
            ExplosionEffect.Play();
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Game over!");
            ScoreText.SetActive(false);
            Manager.ShowlevelCompletePanel();
            GameScoreText.text = $"Score: {Manager.PlayerScore}";
            HighScoreText.text = $"High Score: {Manager.PlayerHighScore}";
        } else if(other.gameObject.TryGetComponent<PointZone>(out var pointZone))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Passed!");
            Manager.PlayerScore++;
            if(Manager.PlayerHighScore < Manager.PlayerScore)
            {
                PlayerPrefs.SetInt("Manager.PlayerHighScore", Manager.PlayerScore);
            }
            ScoreText.GetComponent<TextMeshProUGUI>().text = $"{Manager.PlayerScore}";
        }
    }
}
