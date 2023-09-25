using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatehelicopterBlades : MonoBehaviour
{
    public GameObject mainBlades;
    public GameObject tailBlades;
    public float bladesRotationSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        mainBlades.transform.Rotate(new Vector3(0, 0, 1), bladesRotationSpeed * Time.deltaTime);
        tailBlades.transform.Rotate(new Vector3(1, 0, 0), bladesRotationSpeed * Time.deltaTime);
    }
}
