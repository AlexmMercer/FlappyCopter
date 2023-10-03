using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    [SerializeField] float SendTimer = 1;
    [SerializeField] float Frequency = 2;
    [SerializeField] float Position;
    [SerializeField] GameObject Obstacle;
    [SerializeField] GameObject Player;

    private float obstaclesXPosition = 2.45f;
    private float obstaclesZPosition = 3.0f;
    private float obstaclesHeightLowerValue = 4.5f;
    private float obstaclesHieghtUpperValue = 9.5f;

    private void Update()
    {
        SendTimer -= Time.deltaTime;
        if (SendTimer <= 0)
        {
            Position = Random.Range(obstaclesHeightLowerValue, obstaclesHieghtUpperValue);
            transform.position = new Vector3(obstaclesXPosition,
                                             Position, obstaclesZPosition);
            Instantiate(Obstacle, transform.position, transform.rotation);
            SendTimer = Frequency;
        }
    }
}
