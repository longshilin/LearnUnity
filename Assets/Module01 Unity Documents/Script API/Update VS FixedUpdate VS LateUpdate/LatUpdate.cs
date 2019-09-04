using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatUpdate : MonoBehaviour
{
    void LateUpdate()
    {
        transform.Translate(0, Time.deltaTime, 0);
    }
}
