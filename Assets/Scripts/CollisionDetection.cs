using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public PlayerAttack bp;
    public float knockback;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && bp.IsAttacking)
        {
         
            Debug.Log("Has hit the enemy");
            other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);

            //AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);

        }
    }


}
