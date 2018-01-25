using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testActive : MonoBehaviour {

	//public GameObject GO;

	public bool allOptions = true;
	public bool extended1 = true;
	public bool extended2 = true;

	void OnGUI()
	{
//		if (GUI.Button(new Rect(10, 10, 100, 30), "Enable"))
//		{
//			Debug.Log("Enable: " + GO.name);
//			GO.SetActive(true);
//		}
//		if (GUI.Button(new Rect(10, 50, 100, 30), "Disable"))
//		{
//			Debug.Log("Disable: " + GO.name);
//			GO.SetActive(false);
//		}

	
			allOptions = GUI.Toggle(new Rect(0, 0, 150, 20), allOptions, "Edit All Options");
			GUI.enabled = allOptions;
			extended1 = GUI.Toggle(new Rect(20, 20, 130, 20), extended1, "Extended Option 1");
			extended2 = GUI.Toggle(new Rect(20, 40, 130, 20), extended2, "Extended Option 2");
			GUI.enabled = true;
			if (GUI.Button(new Rect(0, 60, 150, 20), "Ok"))
				print("user clicked ok");
			
	}

}