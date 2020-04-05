using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjInCircle : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObjects = 20;
    public float radius = 5f;

    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 2f;

    private void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            var angle = i * Mathf.PI * 2 / numberOfObjects;
            var pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            Instantiate(prefab, pos, Quaternion.identity);
        }

        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {
                var pos = new Vector3(x, 10, y) * spacing;
                Instantiate(prefab, pos, Quaternion.identity);
            }
        }
    }
}