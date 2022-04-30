using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BossHealthBar : MonoBehaviour
{
    public GameObject pooledObject;

    public int pooledAmount;

    List<GameObject> pooledObjects;

    public Transform NPCPos;

    public GameObject House;
    public GameObject Spawning;
    public Animator HouseAnim;
    public int BossCurrentHealth;
    public int MaxHealth;

    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {

            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }

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
    void Update()
    {
        if (BossCurrentHealth <= 0)
        {
            HouseAnim.SetBool("HouseDies", true);
            Destroy(Spawning);
            StartCoroutine(DestroyHouse());
        }
    }
    IEnumerator DestroyHouse()
    {
        yield return new WaitForSeconds(4.4f);
        Vector3 start = NPCPos.position;
        Destroy(House);
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject, start, transform.rotation);
        }
    }
}

