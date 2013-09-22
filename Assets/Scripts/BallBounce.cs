using UnityEngine;
using System.Collections;

public class BallBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(0f, 3*Mathf.Abs(Mathf.Sin(9.8f*Time.time)), 0f);
	}
}
