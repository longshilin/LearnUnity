using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{

    Dictionary<string, int> list;
    // Start is called before the first frame update
    void Start()
    {
        list = new Dictionary<string, int>();

        list.Add("aa", 11);
        list.Add("bb", 22);
        list.Add("cc", 33);
        print(" " + list["aa"]);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
