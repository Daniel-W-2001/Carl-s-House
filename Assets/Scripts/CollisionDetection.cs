using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int damageToGive;

    public PlayerAttack bp;
    public float knockback;
    public float knockbackUp;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && bp.IsAttacking)
        {
         
            Debug.Log("Has hit the enemy");
            other.GetComponent<EnemyManager>().HurtEnemy(damageToGive);
            other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * knockback, ForceMode.Impulse);
            //other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * knockbackUp, ForceMode.Impulse);

            //AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);

        }
    }


}
