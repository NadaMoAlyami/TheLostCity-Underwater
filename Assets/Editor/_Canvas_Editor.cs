using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(_Canvas))]
public class _Canvas_Editor : Editor
{
    // Start is called before the first frame update
    int number = 0;
    string text;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (number == 0)
        {
            text = "No Canvas Found";
        }
        else
        {
            text = $"Total Canvas : {number}";
        }
        EditorGUILayout.LabelField(text);
        _Canvas mono = (_Canvas)target;
        if (GUILayout.Button("Find All Canvas"))
        { 
            number = mono.find_all_canvas();
        }
        if (GUILayout.Button("Add"))
        {
            if (number != 0)
            {
                mono.target();
            }
        }
    }
}
