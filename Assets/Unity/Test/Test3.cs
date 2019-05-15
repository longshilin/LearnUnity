using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start!");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnApplicationPause()
    {
        print("Pause!");
    }

    void OnDestroy()
    {
        print("Destroy!");
    }
}
