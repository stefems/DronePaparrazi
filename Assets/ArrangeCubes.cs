using UnityEngine;
using System.Collections;

public class ArrangeCubes : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int index = 0;
		//for each row
		for (float xVal = 0.0f; xVal < 3.0f; xVal++) {
			//for each col
			for (float yVal = 0.0f; yVal < 3.0f; yVal++){
				string nameVal = "Cube (" + index + ")";
				//get the child that corresponds to the i
				//Transform childCube = transform.Find(name);
				Debug.Log(transform.Find(nameVal).name);
				//childCube.position = new Vector3(xVal, yVal, 0.0f);
				index++;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
