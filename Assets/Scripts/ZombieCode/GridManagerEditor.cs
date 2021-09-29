using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace ZombieCode
{
    [CustomEditor(typeof(GridManager))]
    public class GridManagerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();   //Make sure to call this unless we want to make custom "drawers" for each variable

            GridManager gridManager = (GridManager)target; //the target will be casted to a gridmanager 

            for (int x = 0; x <= gridManager.grid.GetUpperBound(0); x++) //getupperbound gets the length of the dimention
            {
                EditorGUILayout.BeginHorizontal();

                for (int y = 0; y <= gridManager.grid.GetUpperBound(1); y++)
                {
                    gridManager.grid[x, y] = EditorGUILayout.Toggle(gridManager.grid[x, y], GUILayout.Width(16)); //shows tick boxes
                }

                EditorGUILayout.EndHorizontal();
            }
        }
    }
}

