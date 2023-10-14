using System.Collections;
using UnityEngine;

public class LaunchMissilesTestScript : MonoBehaviour
{
    [SerializeField] GameObject LaunchPosition;
    [SerializeField] GameObject Missile;

    private bool missileLaunched = false;
    private GameObject currentMissile;
    private float reloadTime = 0.05f;
    private float timeSinceLaunch = 0.0f;

    private void Start()
    {
        currentMissile = Instantiate(Missile, LaunchPosition.transform.position, Quaternion.identity);
        currentMissile.transform.SetParent(LaunchPosition.transform);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2) && IsShootApproved() == true)
        {
            LaunchMissile();
            currentMissile.transform.Find("smoke").GetComponent<ParticleSystem>().Play();
            currentMissile.transform.Find("fire").GetComponent<ParticleSystem>().Play();
            currentMissile.GetComponent<AudioSource>().Play();
            StartCoroutine(ReloadAfterDelay());
        }

        if (missileLaunched == true && currentMissile != null)
        {
            currentMissile.transform.Translate(Vector3.forward * 15.0f * Time.deltaTime);
        }
    }

    bool IsShootApproved()
    {
        Ray ray = new Ray(LaunchPosition.transform.position, LaunchPosition.transform.forward);

        if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.TryGetComponent<Barrel>(out var barrel))
            {
                //Debug.Log("Barrel detected!");
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    void LaunchMissile()
    {
        Debug.Log("Цель обнаружена. Запускаю ракету.");
        missileLaunched = true;
        Debug.Log("Пуск осуществлён.");
    }

    IEnumerator ReloadAfterDelay()
    {
        yield return new WaitForSeconds(1.5f);
        ReloadMissile();
        Debug.Log("Перезарядка.");
    }

    void ReloadMissile()
    {
        missileLaunched = false;
        currentMissile = Instantiate(Missile, LaunchPosition.transform.position, Quaternion.identity);
        currentMissile.transform.SetParent(LaunchPosition.transform);
    }
}
