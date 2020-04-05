using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket2Wreck : MonoBehaviour
{
    public GameObject wreck;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        KillSelf();
    }

    void KillSelf()
    {
        var wreckClone = Instantiate(wreck, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}