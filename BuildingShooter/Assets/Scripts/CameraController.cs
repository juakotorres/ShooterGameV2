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
	private float currentZ;
	private float sensivilityX;
	private float sensivilityY;
	private Quaternion rotation;

	// Use this for initialization
	private void Start () {
		camPosition = transform;
		distance = 10.0f;
		currentX = 0.0f;
		currentY = 11.85f;
		currentZ = -10.85f;
		cam = Camera.main;
		rotation = Quaternion.Euler (30.0f, 0.0f, 0.0f);
		gameObject.transform.position = new Vector3 (currentX, currentY, currentZ);



	}

	
	// Update is called once per frame
	private void LateUpdate () {
		Vector3 dir = new Vector3 (0, 0, -distance);
		//Transform localLookAt = lookAt;
		//localLookAt.position = new Vector3 (localLookAt.position.x, localLookAt.position.y + 10, localLookAt.position.z);
		camPosition.position = lookAt.position + rotation * dir;
		camPosition.LookAt (new Vector3(lookAt.position.x,lookAt.position.y+1,lookAt.position.z+10));
	}
}
