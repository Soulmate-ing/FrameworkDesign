using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameworkDesign.Example
{
    public class KillEnemyCommand : ICommand
    {
        public void Execute()
        {
            GameModel.KillCount.Value++;
            if (GameModel.KillCount.Value ==10)
            {
                GamePassEvent.Trigger(); 
            }
        }
    }
}
