﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDestroyObjects : MonoBehaviour
{
    public GameObject enemy;

    void Start() {
        for (int i = 0; i < 5; i++) {
            Instantiate(enemy);
        }
    }
}
