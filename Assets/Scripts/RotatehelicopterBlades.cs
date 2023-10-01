using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatehelicopterBlades : MonoBehaviour
{
    [SerializeField] GameObject mainBlades;
    [SerializeField] GameObject tailBlades;
    [SerializeField] float bladesRotationSpeed;

    void Update()
    {
        mainBlades.transform.Rotate(new Vector3(0, 0, 1), bladesRotationSpeed * Time.deltaTime);
        tailBlades.transform.Rotate(new Vector3(1, 0, 0), bladesRotationSpeed * Time.deltaTime);
    }
}
