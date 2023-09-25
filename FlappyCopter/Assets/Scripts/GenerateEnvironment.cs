using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class GenerateEnvironment : MonoBehaviour
{
    public float sendTimer = 0;
    public float frequency = 5;
    public GameObject floor;

    private void Update()
    {
        sendTimer -= Time.deltaTime;
        if(sendTimer <= 0 )
        {
            Instantiate(floor, new Vector3(8.2066f, 15.68226f, -10.37972f), transform.rotation);
            sendTimer = frequency;
        }
    }
}
