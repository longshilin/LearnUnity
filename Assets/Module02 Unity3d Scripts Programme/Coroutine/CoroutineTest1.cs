using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Time.time + " 1");
        StartCoroutine("Example");
        print(Time.time + " 2");
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 3; i++)
        {
            print(Time.time + " 3");
            StartCoroutine("Test", i);
            print(Time.time + " 4");
        }

        //StartCoroutine("Test");
    }

    IEnumerator Test(int j)
    {
        int m = 0;
        for (int i = 0; i < 3; i++)
        {
            print("第" + j + " - " + (++m) + "次调用");
            print(Time.time + " 5");
            print("协程暂停，控制权转移到Unity3D引擎执行主程序！");
            yield return new WaitForSeconds(5);
            print("Unity3D引擎执行完主程序，协程继续执行余下逻辑！");
            print(Time.time + " 6");
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}