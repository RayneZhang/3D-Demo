﻿using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Unlock() {
		//TODO
		GameObject doorChild = this.transform.Find("Door").gameObject;
		Destroy(doorChild);
	}
}
