using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBrick : MonoBehaviour
{
    public Transform brick;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    Instantiate(brick, new Vector3(i, j, k), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}