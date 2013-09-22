using UnityEngine;
using System.Collections;

public class DuckTrigger : MonoBehaviour {
	
	public GigaFlight duck;
	public Control controller;
	public int ID;
	public int duckCount;
	
	private int initialDuck;
	private bool fired = false;
	
	// Use this for initialization
	void Start () {
		initialDuck = duckCount;
	}
	
	// Update is called once per frame
	void Update () {
		if (!fired && duckCount <= 0) {
			controller.Trigger(ID);
			duck.Activate();
			fired = true;
		}
		
		if (duckCount < initialDuck) {
			if (!fired) {
				if (!gameObject.audio.isPlaying)
					gameObject.audio.Play();
			}
			else 
				gameObject.audio.Stop();
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (!fired && other.gameObject != duck.gameObject) {
			Destroy(other.gameObject);
			--duckCount;
		}
	}
}
