using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public int numOfHearts;

    //UI and array for health
    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;

    void Start()
    {
        playerCurrentHealth = playerMaxHealth;
    }
    void Update()
    {
        if(playerCurrentHealth <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
          //  gameObject.SetActive(false);           
        }

        if (playerCurrentHealth > numOfHearts)
        {
            playerCurrentHealth = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerCurrentHealth)
            {
                hearts[i].sprite = fullHeart;
            }
      
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if (i<numOfHearts)
            {
                hearts[i].enabled = true;
            }

            else
            {
                hearts[i].enabled = false;
            }
        }
    }


    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
    }

    public void SetMaxHealth()
    {
        playerCurrentHealth = playerMaxHealth;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Toast")
        {
            playerCurrentHealth += 1;
            Destroy(collision.gameObject);
        }

    }

  


}
