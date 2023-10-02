using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class DetectorScript : MonoBehaviour
{
    private Building building;
    private PointZone pointZone;
    public GameManager Manager;
    [SerializeField] TextMeshProUGUI GameScoreText;
    [SerializeField] TextMeshProUGUI ScoreText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Building>(out building))
        {
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Game over!");
            Manager.ShowlevelCompletePanel();
            GameScoreText.text = $"Score: {Manager.PlayerScore}";
        } else if(other.gameObject.TryGetComponent<PointZone>(out pointZone))
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            Debug.Log("Passed!");
            Manager.PlayerScore++;
            ScoreText.text = $"{Manager.PlayerScore}";
        }
    }
}
