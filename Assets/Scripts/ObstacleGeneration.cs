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

    private void Update()
    {
        SendTimer -= Time.deltaTime;
        if (SendTimer <= 0)
        {
            Position = Random.Range(4.5f, 9.5f);
            transform.position = new Vector3(2.45f, Position, 3);
            Instantiate(Obstacle, transform.position, transform.rotation);
            SendTimer = Frequency;
        }
    }
}
