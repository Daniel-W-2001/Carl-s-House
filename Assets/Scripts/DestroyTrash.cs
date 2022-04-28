using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrash : MonoBehaviour
{
    public bool hasDamagedPlayer;

    public int damageToGive;

    public GameObject trash;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroyobjects());
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FirstPersonController" && hasDamagedPlayer == false)
        {
            Debug.Log("Collided with player");
            collision.gameObject.GetComponent<PlayerManager>().HurtPlayer(damageToGive);
            hasDamagedPlayer = true;
        }
    }
            IEnumerator Destroyobjects()
    {

        yield return new WaitForSeconds(5f);
        Destroy(trash);
    }
}