using UnityEngine;
using System.Collections;

public class TriggerControl : MonoBehaviour {
	
	public int ID = 0;			//ID of this trigger object
	public Control controller;	//Control script to alert
	public bool repeat = false;	//Whether to fire the trigger every time the trigger is entered or just once
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		if (controller != null) {
			controller.Trigger(ID);
			if (!repeat) {
				Destroy(this);
			}
		}
	}
}
