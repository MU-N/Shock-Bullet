using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamge : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerMovement pm = col.GetComponent<PlayerMovement>();
        if (pm != null)
        {
            pm.Die();
        }
    }
}
