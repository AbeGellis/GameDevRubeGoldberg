using UnityEngine;
using System.Collections;

public class RumbleCam : MonoBehaviour {
	
	public float rumble = 3f;
	
	Vector3 dist;
	bool on = true;
	
	// Use this for initialization
	void Start () {
		dist = transform.position - transform.parent.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (on) {
			transform.position = transform.parent.position + dist + 
				new Vector3(Random.Range(-rumble, rumble), Random.Range(-rumble, rumble), Random.Range(-rumble, rumble));
		}
	}
	
	public void Off() {
		on = false;
		transform.position = transform.parent.position + dist;
	}
}
