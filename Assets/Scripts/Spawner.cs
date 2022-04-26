using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Spawner : MonoBehaviour
{
    public Transform Spawnpoint;
    public float timeBetweenSpawn;
    public float spawnTime;
    public ArrayList[] Enemies;
    public GameObject[] EnemyArray;
    void Start()
    {
        
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

