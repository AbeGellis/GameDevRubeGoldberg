using UnityEngine;
using System.Collections;

public class StopHorizontal : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//Arrest horizontal movement of entering ducks
	void OnTriggerEnter(Collider other) {
		//other.gameObject.rigidbody.velocity = new Vector3(0f, other.gameObject.rigidbody.velocity.y, 0f);
		other.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
	}
}
