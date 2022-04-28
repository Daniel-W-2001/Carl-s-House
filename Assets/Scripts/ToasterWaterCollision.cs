using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterWaterCollision : MonoBehaviour
{
    public GameObject water;
    public bool HasCollided;

    public bool electrify;

    void Start()
    {
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
             water.AddComponent<WaterDamage>();
            electrify = false;
           
        }
    }
}
