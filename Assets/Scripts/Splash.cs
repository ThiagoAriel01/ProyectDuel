﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    [SerializeField] private float timer;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            SceneManager.LoadScene("SceneMenu");
        }
    }
}
