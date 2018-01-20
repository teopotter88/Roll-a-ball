using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {

	public GameObject pickUp;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - pickUp.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = pickUp.transform.position + offset;
	}
}
