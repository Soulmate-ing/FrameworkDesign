using FrameworkDesign;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CounterApp
{
    public struct AddCountCommand : ICommand
    {
        public void Execute()
        {
            CounterModel.Count.Value++;
        }
    }
}
