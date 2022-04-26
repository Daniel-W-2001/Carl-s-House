using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //floats for health and damage for enemies
    public int EnemyCurrentHealth;
    public int MaxHealth;

    public int BatDamage;
    void Start()
    {
        EnemyCurrentHealth = MaxHealth;
    }

    public void HurtEnemy(int damageToGive)
    {
        EnemyCurrentHealth -= damageToGive;
    }
    public void setMaxHealth()
    {
        EnemyCurrentHealth = MaxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bat")

            TakeDamage();
    }
    void TakeDamage()
    {
        EnemyCurrentHealth -= BatDamage;

        if (EnemyCurrentHealth <= 0) Invoke(nameof(destroyEnemy), 1f);
    }
    private void destroyEnemy()
    {
        Destroy(gameObject);
    }


}
 