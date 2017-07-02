using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MianScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start: " + HelloWordDll.HelloWorldProvider.GetHello ());	
	}
	
	// Update is called once per frame
	void Update () {
			
	}
}
