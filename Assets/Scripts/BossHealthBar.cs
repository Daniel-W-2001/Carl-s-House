using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BossHealthBar : MonoBehaviour
{
    public GameObject House;
    public GameObject Spawning;
    public Animator HouseAnim;

    public int BossCurrentHealth;
    public int MaxHealth;

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

        Destroy(House);
    }
}

