using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{
    public Image pauseMenu;
    public static FactionData gfactionData;

    // Start is called before the first frame update
    void Start()
    {
        //pauseMenu.enabled = false;        
        gfactionData = gameObject.AddComponent<FactionData>();
        gfactionData.flag[0] = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if(pauseMenu.isActiveAndEnabled)
        //{
        //    Debug.Log("Enabled");
        //}
    }

    void OnDestroy()
    {
        print(gfactionData.flag[0]);
        print(gfactionData.flag[1]);
    }
}
