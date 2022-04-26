using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //floats for health and damage for enemies
    public int EnemyHealth;
    public int MaxHealth;
    public float damage;

    public int BatDamage;
    void Start()
    {
        EnemyHealth = MaxHealth;
    }

    public void HurtEnemy (int damageToGive)
    {
        //playerCurrentHealth -= damageToGive;
    }














    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bat")

            TakeDamage();
    }
    void TakeDamage()
    {
        EnemyHealth -= BatDamage;

        if (EnemyHealth <= 0) Invoke(nameof(destroyEnemy), 1f);
    }
    private void destroyEnemy()
    {
        Destroy(gameObject);
    }


}
 