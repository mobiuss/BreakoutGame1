using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	private Vector3 PlayerPos = new Vector3(0, 1, 0);
	public float paddleSpeed = 9;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed * Time.deltaTime);
		PlayerPos = new Vector3 (Mathf.Clamp(xPos, -2, 2) , 1, 0);
		transform.position = PlayerPos;
	}
}

