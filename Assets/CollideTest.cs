using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTest : MonoBehaviour
{
    public FirstPersonController controller;
    public bool IsColliding;

    void Start()
    {
        IsColliding = false;
    }
    void FixedUpdate()
    {
        if (IsColliding == false)
        {
            controller.GetComponent<FirstPersonController>().walkSpeed = 7f;
            controller.GetComponent<FirstPersonController>().sprintSpeed = 14f;
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.name == "FirstPersonController" && IsColliding == false)
        {
            IsColliding = true;
            other.gameObject.GetComponent<FirstPersonController>().walkSpeed = 14f;
            other.gameObject.GetComponent<FirstPersonController>().sprintSpeed = 21f;
        } else
        {
            IsColliding = false;
        }
    }
}

