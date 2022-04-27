using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTest : MonoBehaviour
{
    private void OnCollisionEnter(Collider other)
    {
        if (other.tag == "Particle")
        {
            Debug.Log("water found");
        }
    }
}
