using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashflyaround : MonoBehaviour
{

    void Start()
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * 50f, ForceMode.Impulse);
    }
}
