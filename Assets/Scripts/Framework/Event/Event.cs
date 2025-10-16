using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event<T> where T : Event<T>
{
    private static Action myOnEvent;
    public static void Register(Action onEvent)
    {
        myOnEvent += onEvent;
    }
    public static void Unregister(Action onEvent)
    {
        myOnEvent -= onEvent;
    }
    /// <summary>
    ///  �����¼�
    /// </summary>
    public static void Trigger()
    {
        myOnEvent?.Invoke();
    }
}
