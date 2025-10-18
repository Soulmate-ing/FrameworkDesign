using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace CounterApp.Editor
{
    public class EditorCounterApp : EditorWindow
    {
        [MenuItem("EditorCpunterApp/Open")]
        static void Open()
        {
            var window = GetWindow<EditorCounterApp>("Counter App");
            window.position = new Rect(100, 100, 400, 600);
            window.titleContent = new GUIContent(nameof(EditorCounterApp));
            window.Show();
        }
        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                new AddCountCommand().Execute();
            }
            GUILayout.Label(CounterModel.Count.Value.ToString());
            if (GUILayout.Button("-"))
            {
                new SubCountCommand().Execute();
            }
        }
    }
}