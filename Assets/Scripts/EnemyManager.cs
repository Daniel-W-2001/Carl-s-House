using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    //floats for health and damage for enemies
    public int EnemyCurrentHealth;
    public int MaxHealth;

    //trash npc variables
    public GameObject trashObject;
    public bool IsTrash;
    public Transform Trashpos;
    //toaster npc variables
    public GameObject PieceOfToast;
    public bool IsToaster;
    public GameObject Toaster;
    public Transform ToasterPos;


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

        Vector3 start = ToasterPos.position;
        Vector3 trash = Trashpos.position;

        if (EnemyCurrentHealth <= 0 && IsToaster == true)
        {

            Instantiate(PieceOfToast, start, transform.rotation);

        }
        else if (EnemyCurrentHealth <= 0 && IsTrash == true)
        {
            Instantiate(trashObject, trash, transform.rotation);
        }
    }
    private void destroyEnemy()
    {
        Destroy(gameObject);
    }

}
 