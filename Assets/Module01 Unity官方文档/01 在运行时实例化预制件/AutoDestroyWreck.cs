using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyWreck : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        KillSelf();
    }

    void KillSelf()
    {
        Destroy(gameObject);
    }
}