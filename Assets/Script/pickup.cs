using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickup : MonoBehaviour
{
    public GameObject Pickuptext;
    public bool textvisible;


    void Start()
    {
        Pickuptext.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickuptext.SetActive(true);
            textvisible = true;
        }
        else Pickuptext.SetActive(false);
        textvisible = false;
    }

}

       
    

