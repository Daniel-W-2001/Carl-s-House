using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;

public class MovementTrash : MonoBehaviour
{
    public Animator TrashAnim;
    public GameObject Trash;
    public NavMeshAgent Agent;

    void Start()
    {
       if (TrashAnim == null)
        {
            return;
        }

        TrashAnim = GetComponent<Animator>();
        Trash.GetComponent<EnemyAI>().enabled = false;
        Trash.GetComponent<NavMeshAgent>().enabled = false;

    }

    void Update()
    {
        if (TrashAnim == null)
        {
            return;
        }

        StartCoroutine(PlayTrashWalk());
    }
    IEnumerator PlayTrashWalk()
    {
        yield return new WaitForSeconds(2.3f);

       

        TrashAnim.applyRootMotion = true;
        TrashAnim.SetBool("TrashJump", true);
        Trash.GetComponent<EnemyAI>().enabled = true;
        Trash.GetComponent<NavMeshAgent>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bat")
        {
            Destroy(TrashAnim);
            Destroy(Agent);
        }

    }
}

