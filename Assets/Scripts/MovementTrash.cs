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
       

        TrashAnim = GetComponent<Animator>();
        Trash.GetComponent<NavMeshAgent>().enabled = false;

    }

    void Update()
    {
        StartCoroutine(PlayTrashWalk());
    }
    IEnumerator PlayTrashWalk()
    {
        yield return new WaitForSeconds(2.3f);

       

        TrashAnim.applyRootMotion = true;
        TrashAnim.SetBool("TrashJump", true);
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

