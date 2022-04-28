using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyManager : MonoBehaviour
{
    //floats for health and damage for enemies
    public int EnemyCurrentHealth;
    public int MaxHealth;

    //trash npc variables
    public bool IsTrash;

    public GameObject pooledObject;

    public int pooledAmount;

    List<GameObject> pooledObjects;
    //toaster npc variables
    public GameObject PieceOfToast;
    public bool IsToaster;

    //Npc position
    public Transform NPCPos;


    public int BatDamage;
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bat")

            TakeDamage();
    }
   public void TakeDamage()
    {
        EnemyCurrentHealth -= BatDamage;

        if (EnemyCurrentHealth <= 0) Invoke(nameof(destroyEnemy), 1f);

        Vector3 start = NPCPos.position;

        if (EnemyCurrentHealth <= 0 && IsToaster == true)
        {

            Instantiate(PieceOfToast, start, transform.rotation);

        }
        if (EnemyCurrentHealth <= 0 && IsTrash == true)
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                GameObject obj = (GameObject)Instantiate(pooledObject, start, transform.rotation);
                IsTrash = false;
            }
        }
        }
    private void destroyEnemy()
    {
        Destroy(gameObject);
    }

}
 