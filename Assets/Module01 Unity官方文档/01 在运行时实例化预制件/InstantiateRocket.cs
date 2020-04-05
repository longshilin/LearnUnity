using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRocket : MonoBehaviour
{
    public Rigidbody rocket;
    public float speed;

    void FireRocket()
    {
        var rocketClone = Instantiate(rocket, transform.position, transform.rotation);
        rocketClone.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireRocket();
        }
    }
}