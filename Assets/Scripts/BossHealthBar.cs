using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthBar : MonoBehaviour
{
    public float speed = 1.0f;

    public Color startColor;
    public Color endColor;
    float startTime;
    

    public int BossCurrentHealth;
    public int MaxHealth;

    void Start()
    {
        startTime = Time.time;

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
        if (BossCurrentHealth > 8)
        {
            float t = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);

        }
    }
}

