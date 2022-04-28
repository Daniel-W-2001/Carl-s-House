using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCollisionDetect : MonoBehaviour
{
    public float knockback;
    //public float knockbackUp;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {

            Debug.Log("Has hit the enemy");
            other.gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * knockback, ForceMode.Impulse);

           
        }
    }
}