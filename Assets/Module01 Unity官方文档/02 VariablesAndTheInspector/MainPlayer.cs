using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VariablesAndTheInspector {

    public class MainPlayer : MonoBehaviour {
        public string myName;

        // Start is called before the first frame update
        private void Start() {
            Debug.Log("I am alive and my name is " + myName);
        }

        // Update is called once per frame
        private void Update() {
        }
    }
}