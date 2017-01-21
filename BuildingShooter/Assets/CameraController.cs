using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform  lookAt;
	public Transform camPosition;

	private Camera cam;

	private float distance;
	private float currentX;
	private float currentY;
	private float sensivilityX;
	private float sensivilityY;

	// Use this for initialization
	private void Start () {
		camPosition = transform;
		distance = 10.0f;
		currentX = 0.0f;
		currentY = 0.0f;
		sensivilityX = 3.0f;
		sensivilityY = 1.0f;
		cam = Camera.main;

	}

	private void Update () {
		currentX += Input.GetAxis ("Mouse Y");
		currentY += Input.GetAxis ("Mouse X");
		currentY = Mathf.Clamp (currentY,0,50.0f);
		currentX = Mathf.Clamp (currentX,0,50.0f);
	}
	
	// Update is called once per frame
	private void LateUpdate () {
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentX, currentY, 0);
		camPosition.position = lookAt.position + rotation * dir;
		camPosition.LookAt (lookAt.position);
	}
}
