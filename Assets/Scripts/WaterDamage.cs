using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour
{
    public int damageToGive = 1;
    public void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.name == "FirstPersonController")
        {
            Debug.Log("Collided with player");
            other.gameObject.GetComponent<PlayerManager>().HurtPlayer(damageToGive);

        }
    }
}
