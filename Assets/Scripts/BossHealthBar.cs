using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BossHealthBar : MonoBehaviour
{
    public GameObject House;
    public GameObject Spawning;
    public Animator HouseAnim;
    public GameObject Particle_1, Particle_2, Particle_3;
    public int BossCurrentHealth;
    public int MaxHealth;

    void Start()
    {
        Particle_1.SetActive(false);
        Particle_2.SetActive(false);
        Particle_3.SetActive(false);
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
            Particle_1.SetActive(true);
            Particle_2.SetActive(true);
            Particle_3.SetActive(true);
        }
    }
    IEnumerator DestroyHouse()
    {
        yield return new WaitForSeconds(4.4f);

        Destroy(House);
        Destroy(Particle_1, 3.0f);
        Destroy(Particle_2, 3.0f);
        Destroy(Particle_3, 3.0f);
    }
}

