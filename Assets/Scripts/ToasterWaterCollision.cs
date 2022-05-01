using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterWaterCollision : MonoBehaviour
{
    public GameObject water;
    public bool HasCollided;

    public GameObject ElectricityWater;

    public Rigidbody Toaster;
    public Rigidbody Vase;

    public bool electrify;

    void Start()
    {
        ElectricityWater.SetActive(false);
        HasCollided = false;
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
        if(other.gameObject.name == "Toaster Variant" && HasCollided == false)
        {
            HasCollided = true;
            electrify = true;
        }
        if (electrify == true)
        {
            Vase.constraints = RigidbodyConstraints.FreezePosition;
            Toaster.constraints = RigidbodyConstraints.FreezePosition;
            ElectricityWater.SetActive(true);
            water.AddComponent<WaterDamage>();
         
            electrify = false;
           
        }
    }
}
