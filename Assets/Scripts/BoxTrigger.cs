using UnityEngine;
using System.Collections;

public class BoxTrigger : MonoBehaviour {
	public Light sun;

	// Use this for initialization
	void Start () {
		light.enabled = false;
		sun.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		light.enabled = true;
		sun.enabled = false;
	}
}
