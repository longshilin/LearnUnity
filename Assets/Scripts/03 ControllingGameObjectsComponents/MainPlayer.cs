using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ControllingGameObjectsComponents {

    public class MainPlayer : MonoBehaviour {

        // Start is called before the first frame update
        private void Start() {
            Rigidbody rb = GetComponent<Rigidbody>();

            // Change the mass of the object's Rigidbody.
            rb.mass = 10f;

            // Add a force to the Rigibody
            rb.AddForce(Vector3.up * 10f);

            // Close gravity
            rb.useGravity = false;
        }

        // Update is called once per frame
        private void Update() {
        }
    }
}