using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class GenerateEnvironment : MonoBehaviour
{
    [SerializeField] float SendTimer = 0;
    [SerializeField] float Frequency = 5;
    [SerializeField] GameObject Floor;

    private void Update()
    {
        SendTimer -= Time.deltaTime;
        if(SendTimer <= 0 )
        {
            Instantiate(Floor, new Vector3(8.2066f, 15.68226f, -10.37972f), transform.rotation);
            SendTimer = Frequency;
        }
    }
}
