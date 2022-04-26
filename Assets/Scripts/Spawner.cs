using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
public class Spawner : MonoBehaviour
{
    public int DamageWhileAirborne;
    public bool AnimIsPlaying;

    public Animator vaseAnim;

    public Transform Spawnpoint;
    public float timeBetweenSpawn;
    public float spawnTime;
    public ArrayList[] Enemies;
    public GameObject[] EnemyArray;
    void Start()
    {

        StartCoroutine(RootApply());
        
        vaseAnim.GetComponent<Animator>();
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

        obj.GetComponent<NavMeshAgent>().enabled = true;
        obj.GetComponent<Animator>().SetBool("AnimIsPlaying", true);
    }
    IEnumerator RootApply()
    {
        yield return new WaitForSeconds(4f);

        vaseAnim.applyRootMotion = true;
    }
        


    }

