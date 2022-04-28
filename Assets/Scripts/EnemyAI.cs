using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public AirborneEnemy Enemy;

    public int damageToGive;

    public NavMeshAgent Agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float sightRange;
    public bool playerInSightRange;

    //Attacking
    private void Awake()
    {

        player = GameObject.Find("FirstPersonController").transform;
        Agent = GetComponent<NavMeshAgent>();
    }
    public void Start()
    {
        Enemy.IsAirborne = true; 
    }
    void FixedUpdate()
    {
        if (Enemy.IsAirborne == true)
        {
            damageToGive = 2;
        }

        else
        {
            damageToGive = 1;
        }
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (playerInSightRange) ChasePlayer();
    }
    private void ChasePlayer()
    {
        Agent.SetDestination(player.position);

        transform.LookAt(player);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "FirstPersonController")
        {
            Debug.Log("Collided with player");
            collision.gameObject.GetComponent<PlayerManager>().HurtPlayer(damageToGive);

        } 
    }
}