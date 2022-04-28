using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashDamageEnemy : MonoBehaviour
{
    public float knockback;
    public bool hasDamagedEnemy = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && hasDamagedEnemy == false)
        {
            Debug.Log("Collided with enemy");
            collision.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);
            collision.gameObject.GetComponent<EnemyManager>().TakeDamage();

            hasDamagedEnemy = true;
        }
    }
}
