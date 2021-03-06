﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppelForHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement playerMove = collision.GetComponent<PlayerMovement>();
        if (playerMove != null)
        {
            playerMove.TakeHealth();
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
