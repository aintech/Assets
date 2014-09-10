using UnityEngine;
using System.Collections;

public class StoryScript : MonoBehaviour {

	void OnGUI () {
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		if(GUILayout.Button("Пропустить пока несуществующую заставку")) {
			Application.LoadLevel("Planet");
		}
		
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}
}