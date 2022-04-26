using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
public class MovementVase : MonoBehaviour
{
    public Animator vaseAnim;
    public bool AnimIsPlaying;
    public GameObject Vase;
    public NavMeshAgent Agent;

    void Start()
    {
        vaseAnim = GetComponent<Animator>();
        Vase.GetComponent<NavMeshAgent>().enabled = false;

    }

    void Update()
    {
        StartCoroutine(PlayWalk());
    }
    IEnumerator PlayWalk()
    {
        yield return new WaitForSeconds(2.3f);
        vaseAnim.applyRootMotion = true;
        vaseAnim.SetBool("VaseJump", true);
        Vase.GetComponent<NavMeshAgent>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bat")
        {
            Destroy(vaseAnim);
            Destroy(Agent);
        }

    }
}
