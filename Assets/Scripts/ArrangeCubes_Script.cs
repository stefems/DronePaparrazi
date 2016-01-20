using UnityEngine;
using System.Collections;

public class ArrangeCubes : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int index = 1;
		//for each row
		for (float xVal = 0.0f; xVal < 3.0f; xVal++) {
			//for each col
			for (float zVal = 0.0f; zVal < 3.0f; zVal++){
				string nameVal = "Cube (" + index + ")";
				//get the child that corresponds to the index
				Transform childCube = transform.Find(nameVal);
				childCube.position = new Vector3(xVal, 0.0f, zVal);
				index++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
