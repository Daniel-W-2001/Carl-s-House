using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //floats for health and damage for enemies
    public float Health;
    public float damage;

    //will tell if the enemy is airborne or not. This will also determine damage
    public bool IsAirborne;
    public bool IsGrounded;

    //Bool for each NPC that will trigger other reactions
    public bool IsToaster;
    public bool IsTrashbag;
    public bool IsVase;

    //Scaleable enemy script WIP
   
}
