using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
public class MovementToaster : MonoBehaviour
{
    

    public Animator ToasterAnim;
    public GameObject Toaster;
    public NavMeshAgent Agent;

    void Start()
    {
        if (ToasterAnim == null)
        {
            return;
        }

        ToasterAnim = GetComponent<Animator>();
        Toaster.GetComponent<EnemyAI>().enabled = false;
        Toaster.GetComponent<NavMeshAgent>().enabled = false;

    }

    void Update()
    {

        if (ToasterAnim == null)
        {
            return;
        }

        StartCoroutine(PlayToasterWalk());
    }
    IEnumerator PlayToasterWalk()
    {
        yield return new WaitForSeconds(2.3f);


        ToasterAnim.applyRootMotion = true;
        ToasterAnim.SetBool("ToasterJump", true);
        Toaster.GetComponent<NavMeshAgent>().enabled = true;
        Toaster.GetComponent<EnemyAI>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bat")
        {
            Destroy(ToasterAnim);
            Destroy(Agent);
        }

    }
}
