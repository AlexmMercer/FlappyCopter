using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 direction;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] float force = 5.0f;

    private void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * force;
        }

        direction.y += gravity * Time.deltaTime * 1.5f;
        transform.position += direction * Time.deltaTime;
    }
}