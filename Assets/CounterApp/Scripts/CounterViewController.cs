using FrameworkDesign;
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
            
            CounterModel.Count.OnValueChanged += OnCountChanged;
            //主动调用一次
            OnCountChanged(CounterModel.Count.Value);
            transform.Find("BtnAdd").GetComponent<Button>().onClick.AddListener(() =>
            {
                //交互逻辑
                CounterModel.Count.Value++;
            });
            transform.Find("BtnSub").GetComponent<Button>().onClick.AddListener(() =>
            {
                CounterModel.Count.Value--;

            });
        }

        private void OnCountChanged(int newCount)
        {
            transform.Find("CountText").GetComponent<Text>().text = newCount.ToString();
        }
     
        private void OnDestroy()
        {
            CounterModel.Count.OnValueChanged -= OnCountChanged;
        }
    }
    public static class CounterModel
    {
        public static BindableProperty<int> Count = new BindableProperty<int>() 
        { 
            Value = 0 
        };
    }
}
