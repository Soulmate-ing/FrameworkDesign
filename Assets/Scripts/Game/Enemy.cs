using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Emeny : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);

            KilledOneEnemyEvent.Trigger();
        }
    }
}

