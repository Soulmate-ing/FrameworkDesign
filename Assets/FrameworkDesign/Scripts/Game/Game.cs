using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            GameStartEvent.Register(OnGameStart);
            KilledOneEnemyEvent.Register(OnEnemyKilled);
        }

        private void OnEnemyKilled()
        {
            GameModel.KillCount++;
            if (GameModel.KillCount == 10)
            {
                GamePassEvent.Trigger();
            }
        }

        private void OnGameStart()
        {
            transform.Find("Enemies").gameObject.SetActive(true);
        }
        private void OnDestroy()
        {
            GameStartEvent.Unregister(OnGameStart);
            KilledOneEnemyEvent.Unregister(OnEnemyKilled);
        }
    }
}
