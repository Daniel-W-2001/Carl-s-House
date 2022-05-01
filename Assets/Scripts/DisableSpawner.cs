using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableSpawner : MonoBehaviour
{
    public Spawner spawner;

    void Awake()
    {
        spawner.enabled = false;
        StartCoroutine(StartSpawner());
    }
    IEnumerator StartSpawner()
    {
        yield return new WaitForSeconds(12f);
        spawner.enabled = true;
    }
}
