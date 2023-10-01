using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    [SerializeField] float sendTimer = 1;
    [SerializeField] float frequency = 2;
    [SerializeField] float position;
    [SerializeField] GameObject obstacle;
    [SerializeField] GameObject player;

    private void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            position = Random.Range(4.5f, 9.5f);
            transform.position = new Vector3(2.45f, position, 3);
            Instantiate(obstacle, transform.position, transform.rotation);
            sendTimer = frequency;
        }
    }
}
