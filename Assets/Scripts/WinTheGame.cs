using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTheGame : MonoBehaviour
{
    public BossHealthBar healthbar;
    void Update()
    {
        if(healthbar.BossCurrentHealth <= 0)
        {
            StartCoroutine(Win());
        }
    }
    IEnumerator Win()
    {
        yield return new WaitForSeconds(6f);

        SceneManager.LoadScene("WinScreen");
    }
}
