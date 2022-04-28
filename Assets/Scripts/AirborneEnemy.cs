using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirborneEnemy : MonoBehaviour
{
    public bool IsAirborne;
    void Start()
    {
        IsAirborne = true;

        StartCoroutine(Airbornephase());
    }

    IEnumerator Airbornephase()
    {
        yield return new WaitForSeconds(2.3f);
        IsAirborne = false;
    }
}
