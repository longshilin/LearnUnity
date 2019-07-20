using UnityEngine;
using System;
using System.Collections;


public class DelegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num);

    void Start()
    {
        //创建3个MyDelegate委托类的实例
        MyDelegate myDelegate1 = new MyDelegate(this.PrintNum);
        MyDelegate myDelegate2 = new MyDelegate(this.PrintDoubleNum);
        MyDelegate myDelegate3 = new MyDelegate(this.PrintTripleNum);

        MyDelegate myDelegates = null;
        //使用Delegate类的静态方法Combine
//        myDelegates = (MyDelegate) Delegate.Combine(myDelegates, myDelegate1);
//        myDelegates = (MyDelegate) Delegate.Combine(myDelegates, myDelegate2);
//        myDelegates = (MyDelegate) Delegate.Combine(myDelegates, myDelegate3);

        // C#编译器为委托实例重载了“+=”和“-=”操作符来对应Delegate.Combine和Delegate.Remove。
        myDelegates += myDelegate1;
        myDelegates += myDelegate2;
        myDelegates += myDelegate3;
        //将myDelegates传入Print方法
        this.Print(10, myDelegates);
    }

    void Print(int value, MyDelegate md)
    {
        if (md != null)
        {
            md(value);
        }
        else
        {
            Debug.Log("myDelegate is Null!!!");
        }
    }

    void PrintNum(int num)
    {
        Debug.Log("1 result Num: " + num);
    }

    void PrintDoubleNum(int num)
    {
        int result = num + num;
        Debug.Log("2 result num is : " + result);
    }

    void PrintTripleNum(int num)
    {
        int result = num + num + num;
        Debug.Log("3 result num is : " + result);
    }
}