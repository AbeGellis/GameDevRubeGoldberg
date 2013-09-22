using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Control : MonoBehaviour {
	
	public List<Birdwatch> cams;
	public List<GameObject> breakaway;
	
	float counter0 = -1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (counter0 > 0) {
			counter0 -= Time.deltaTime;
			if (counter0 <= 0)
				Destroy(breakaway[0]);
		}
	}
	
	public void Trigger(int ID) {
		print("Control Trigger: " + ID);
		switch (ID) {
		case 0:
			cams[0].ChangeFollow(false);
			break;
		case 1:
			cams[0].Enable(false);
			cams[1].Enable(true);
			break;
		case 2:
			cams[1].Enable(false);
			cams[2].Enable(true);
			counter0 = 2f;
			break;
		case 3:
			cams[2].Enable(false);
			cams[3].Enable(true);
			break;
		case 4:
			cams[3].Enable(false);
			cams[4].Enable(true);
			break;
		case 5:
			cams[4].ChangeFollow(false);
			break;
		}
	}
}
