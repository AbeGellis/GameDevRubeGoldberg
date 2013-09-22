using UnityEngine;
using System.Collections;

public class GigaFlight : MonoBehaviour {
	
	public GameObject target;
	public ParticleSystem fire;
	
	bool fly = false;
	Vector3 dirToTarget;
	
	// Use this for initialization
	void Start () {
		dirToTarget = (target.transform.position - transform.position).normalized;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Activate() {
		fly = true;
		fire.gameObject.SetActive(true);
	}
	
	void FixedUpdate() {
		if (fly) {
			rigidbody.AddForce(dirToTarget * 30);
		}
	}
}
