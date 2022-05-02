using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;
public class Spawner : MonoBehaviour
{
    public Transform Spawnpoint;
    public float timeBetweenSpawn;
    public float spawnTime;
    public GameObject[] EnemyArray;


    void Awake()
    {
        spawnTime = 12f;
        timeBetweenSpawn = 3f;
    }
    void FixedUpdate()
    {
        if (Time.time > spawnTime)
        {

            spawnTime = Time.time + timeBetweenSpawn;
            Spawn();
        }
    }
    void Spawn()
    {

        Vector3 start = Spawnpoint.position;

        int Enemyspawn = Random.Range(0, EnemyArray.Length);

        GameObject obj = (GameObject)Instantiate(EnemyArray[Enemyspawn], start, transform.rotation);


    }
}

