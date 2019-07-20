using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ControllingGameObjectsComponents {

    public class Enemy : MonoBehaviour {
        public GameObject player;

        public Transform playerTransform;

        // Start is called before the first frame update
        private void Start() {
            // Start the enemy ten units behind the player character.
            transform.position = player.transform.position - Vector3.forward * 10f;

            transform.position = playerTransform.position - Vector3.forward * 20f;
        }

        // Update is called once per frame
        private void Update() {
        }
    }
}