using UnityEngine;
using System.Collections;


[RequireComponent (typeof(Rigidbody))]
public class Ball : MonoBehaviour {
	
	public float InitialBallVelocity = 600f;
	private Rigidbody rb;
	private bool ballInPlay;
	
	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && !ballInPlay) {
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(InitialBallVelocity, InitialBallVelocity, 0));
		}
	}
}
