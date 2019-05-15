using System.Collections;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    // 使用C#的迭代器来实现协程功能
    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(5);
        print("WaitAndPrint " + Time.time);
    }

    IEnumerator TestWWW()
    {
        string url = "https://cdn.pixabay.com/photo/2015/06/27/16/38/sky-823624_960_720.jpg";
        WWW www = new WWW(url);
        yield return www;
    }

    //IEnumerator Start()
    //{
    //    print("Starting " + Time.time);

    //    // 链接协程，先执行WaitAndPrint
    //    yield return StartCoroutine(WaitAndPrint);
    //    print("Done " + Time.time);

    //}
}
