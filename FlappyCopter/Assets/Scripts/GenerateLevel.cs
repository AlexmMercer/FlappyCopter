using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public float lifeTime = 20;

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0) Destroy(gameObject);
        else transform.Translate(0, 0, (-4) * Time.deltaTime);
    }
}
