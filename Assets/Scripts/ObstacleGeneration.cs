using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleGeneration : MonoBehaviour
{
    public float sendTimer = 1;
    public float frequency = 2;
    public float position;
    public GameObject obstacle;
    public GameObject player;

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

       if(player == null)
        {
            Time.timeScale = 0.0f;
        }
    }
}
