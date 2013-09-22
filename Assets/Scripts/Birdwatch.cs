using UnityEngine;
using System.Collections;

public class Birdwatch : MonoBehaviour {
	
	public GameObject target;	//Object to watch
	public bool follow;			//Whether to follow alongside or not
	
	private Vector3 difference;
	
	// Use this for initialization
	void Start () {
		difference = target.transform.position - transform.position;
		transform.LookAt(target.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		if (follow) {
			transform.position  = target.transform.position - difference;
		}
		else {
			transform.LookAt(target.transform.position);
		}
	}
	
	//Switches between following or not
	public void ChangeFollow(bool toFollow) {
		if (toFollow && !follow)
			difference = target.transform.position - transform.position;
		
		follow = toFollow;
	}
	
	public void ChangeTarget(GameObject newTarget) {
		target = newTarget;
		difference = target.transform.position - transform.position;
	}
	
	public void Enable(bool enable) {
		gameObject.SetActive(enable);
	}
}
