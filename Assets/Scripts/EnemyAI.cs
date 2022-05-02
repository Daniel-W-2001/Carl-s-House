using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public AirborneEnemy Enemy;

    public int damageToGive;

    public int damageToGiveInAir;

    public int damageToGiveOnGround;

    public NavMeshAgent Agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float sightRange;
    public bool playerInSightRange;

    //Attacking
    private void Awake()
    {
        damageToGive = damageToGiveOnGround;
        player = GameObject.Find("FirstPersonController").transform;
        Agent = GetComponent<NavMeshAgent>();
    }
    public void Start()
    {
        if (Agent == null)
        {
            return;
        }
        Enemy.IsAirborne = true; 
    }
    void FixedUpdate()
    {
        if (Enemy.IsAirborne == true)
        {
            damageToGive = damageToGiveInAir;
        }

        else
        {
            damageToGive = damageToGiveOnGround;
        }
    }

    private void Update()
    {
        if (Agent == null)
        {
            return;
        }

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