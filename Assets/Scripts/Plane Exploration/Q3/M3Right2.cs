﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3Right2 : MonoBehaviour {

	public GameObject gameObject;
	public GameObject player;

	private Vector3[] right2;

	private MeshFilter meshFilter;
	private Mesh mesh;

	public bool collide = false;

	void Start () {

		// get mesh from mesh filter
		meshFilter = (MeshFilter)gameObject.GetComponent(typeof(MeshFilter));


		// set mesh
		right2 = new Vector3[] {
			new Vector3 (0, 3, 2),
			new Vector3 (0, 1, 4),
			new Vector3 (2, 1, 4),
			new Vector3 (2, 3, 2)
		};

		mesh = new Mesh ();

		mesh.vertices = new Vector3[] {
			right2 [0], right2 [1], right2 [3],
			right2 [3], right2 [1], right2 [2]
		};

		mesh.triangles = new int[] { 0, 1, 2, 3, 4, 5 };

		// set collide
		collide = false;


	}

	// render
	void Update () {

		if (collide)
			meshFilter.mesh = mesh;
		else
			meshFilter.mesh = null;

	}

	// collision trigger
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Player")) {
			collide = true;
			player.GetComponent<Player3> ().right2 = true;
		}
	}
}
