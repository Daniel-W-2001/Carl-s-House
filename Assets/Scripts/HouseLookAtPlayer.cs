using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class HouseLookAtPlayer : MonoBehaviour
{
    public Transform Player;
    void Update()
    {
        transform.LookAt(Player);
        
    }
    
}
