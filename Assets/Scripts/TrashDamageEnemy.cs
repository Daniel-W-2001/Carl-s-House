using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDamageEnemy : MonoBehaviour
{
    public bool hasDamagedEnemy = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && hasDamagedEnemy == false)
        {
            Debug.Log("Collided with player");
            collision.gameObject.GetComponent<EnemyManager>().TakeDamage();

            hasDamagedEnemy = true;
        }
    }
}
