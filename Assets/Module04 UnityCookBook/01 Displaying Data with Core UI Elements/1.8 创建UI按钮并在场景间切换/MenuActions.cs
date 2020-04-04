using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuActions : MonoBehaviour
{
    public void Menbu_Action_GotoPage(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}