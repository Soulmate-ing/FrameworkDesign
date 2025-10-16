using FrameworkDesign.Example;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    private void Start()
    {
        GamePassEvent.Register(OnGamePass);
    }
    private void OnGamePass()
    {
        transform.Find("Canvas/GamePassPanel").gameObject.SetActive(true);
    }
    private void OnDestroy()
    {
        GamePassEvent.Unregister(OnGamePass);
    }
}
