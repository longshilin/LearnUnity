using System;
using UnityEngine;

//实现控制攻击发生，测试事件响应
public class Controller : MonoBehaviour
{
    [SerializeField]
    public BaseUnit unit;

    private void Start()
    {
    }

    private void Update()
    {
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "攻击测试"))
            this.unit.BeAttacked();
    }
}