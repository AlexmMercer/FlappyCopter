using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public float lifeTime = 20;
    public float speed = 5.0f;

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0) Destroy(gameObject);
        else transform.Translate(0, 0, (-speed) * Time.deltaTime);
    }
}
