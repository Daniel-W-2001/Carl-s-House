using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthBar : MonoBehaviour
{
    public int BossCurrentHealth;
    public int MaxHealth;
    public GameObject house;
    void Start()
    {
        BossCurrentHealth = MaxHealth;   
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Ouch!");
            BossCurrentHealth -= 1;
        }
    }
}

