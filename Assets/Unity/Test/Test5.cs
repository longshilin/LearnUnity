using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    public GameObject[] cube;
    // Start is called before the first frame update
    void Awake()
    {
        cube = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            cube[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            cube[i].transform.position += Vector3.forward * Time.deltaTime * Random.Range(-1,3);
        }

    }
}
