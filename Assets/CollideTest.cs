using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTest : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.name == "FirstPersonController")
        {
            Debug.Log("Collide");
        }
        
    }
}
