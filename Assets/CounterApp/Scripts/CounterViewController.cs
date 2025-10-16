using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{
    public class CounterViewController : MonoBehaviour
    {
        private void Start()
        {
            OnCountedChangedEvent.Register(OnCountChanged);

            //主动调用一次
            OnCountChanged();
            transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                CounterModel.Count++;
            });
            transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener(() =>
            {
                CounterModel.Count--;
                
            });
        }

        private void OnCountChanged()
        {
            transform.Find("CountText").GetComponent<Text>().text = CounterModel.Count.ToString();
        }
     
        private void OnDestroy()
        {
            OnCountedChangedEvent.Unregister(OnCountChanged);
        }
    }
    public static class CounterModel
    {
        private static int mCount = 0;
        
        public static int Count
        {
            get
            {
                return mCount;
            }
            set
            {
                if (value != mCount)
                {
                    mCount = value;
                    OnCountedChangedEvent.Trigger();
                }
            }
        }
    }
    public class OnCountedChangedEvent : Event<OnCountedChangedEvent>
    {

    }
}
