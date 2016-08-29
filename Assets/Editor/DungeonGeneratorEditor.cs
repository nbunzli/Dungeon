using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DungeonGenerator))]
public class DungeonGeneratorEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		DungeonGenerator myScript = (DungeonGenerator)target;
		if(GUILayout.Button("Generate Dungeon"))
		{
			myScript.GenerateDungeon();
		}
	}
}