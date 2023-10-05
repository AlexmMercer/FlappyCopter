using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerController : MonoBehaviour
{
    private Vector3 direction;
    private float lowerNormalYPos = 1.0f;
    private float upperNormalYPos = 20.0f;
    [SerializeField] GameManager Manager;
    [SerializeField] TextMeshProUGUI GameScoreText;
    [SerializeField] AudioClip ExplosionClip;
    [SerializeField] GameObject ScoreText;
    [SerializeField] float Gravity = -9.8f;
    [SerializeField] float Force = 5.0f;

    private void Start()
    {
        ScoreText.SetActive(true);
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void Update()
    {
        if (transform.position.y <= lowerNormalYPos ||
            transform.position.y >= upperNormalYPos)
        {
            Destroy(gameObject);
            gameObject.GetComponent<AudioSource>().Stop();
            Debug.Log("Game over!");
            ScoreText.SetActive(false);
            Manager.ShowlevelCompletePanel();
            GameScoreText.text = $"Score: {Manager.PlayerScore}";
        }
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * Force;
        }

        direction.y += Gravity * Time.deltaTime * 1.5f;
        transform.position += direction * Time.deltaTime;
    }
}
