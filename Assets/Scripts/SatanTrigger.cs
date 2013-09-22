using UnityEngine;
using System.Collections;

public class SatanTrigger : MonoBehaviour {
	
	public RumbleCam rumble;
	public GameObject satan;
	public ParticleSystem miasma;
	public ParticleSystem boom;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter() {
		rumble.Off();
		satan.renderer.enabled = false;
		miasma.loop = false;
		boom.Play();
		boom.audio.Play();
	}
}
