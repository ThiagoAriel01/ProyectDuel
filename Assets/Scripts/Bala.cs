﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] public float velocidad, targetTime;


    void Update()
    {
        transform.position += transform.forward * velocidad * Time.deltaTime;
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemigo" || collision.gameObject.tag == "terrain" || collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
