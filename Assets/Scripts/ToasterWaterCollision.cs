using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
public class ToasterWaterCollision : MonoBehaviour
{
    public ParticleSystem system;

    public GameObject water;

    public bool HasCollided;

    public GameObject ElectricityWater;

    public GameObject Vase;

    public bool electrify;

    public Animator VaseElectrocuted;
    


    void Start()
    {
        ElectricityWater.SetActive(false);
        HasCollided = false;
 
        //VaseElectrocuted = GetComponent<Animator>();
        
    }
    void FixedUpdate()
    {
        if (HasCollided == false)
        {
            electrify = false;
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("ToastyBoy") && HasCollided == false)
        {
            HasCollided = true;
            electrify = true;
        }
        if (electrify == true)
        {
            ElectricityWater.SetActive(true);
            electrify = false;
            Destroy(Vase.GetComponent<NavMeshAgent>());
            Destroy(other.gameObject.GetComponent<NavMeshAgent>());

            Destroy(Vase.GetComponent<EnemyAI>());
            Destroy(other.gameObject.GetComponent<EnemyAI>());

            other.GetComponent<Animator>().Play("ToasterElectrocuted");
            Vase.GetComponent<Animator>().Play("VaseElectrocuted");
            

            Destroy(Vase, 2f);
            Destroy(other, 2f);
            system.Pause();
        }
    }
      
}

