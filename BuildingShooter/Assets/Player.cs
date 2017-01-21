using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private  Transform playerTransform;
	private float speedX;
	private float speedZ;
	private float speed;
	private float xPosition;
	private float zPosition;

	// Use this for initialization
	void Start () {
		playerTransform = gameObject.transform;
		speedX = 0.0f;
		speedZ = 0.0f;
		speed = 0.0f;
		xPosition = playerTransform.transform.position.x;
		zPosition = playerTransform.transform.position.z;
		//Quaternion myQuaternion = Quaternion.Euler(,)

	}
	
	// Update is called once per frame
	void Update () {
		xPosition += speedX; 
		zPosition += speedZ;
		playerTransform.position = new Vector3(xPosition,playerTransform.transform.position.y,zPosition);
	}


	public void setSpeedX(float speedX) {
		this.speedX = speedX*(0.5f);
		this.speed = speedX * (0.5f);
	}

	public void setSpeedZ(float speedZ) {
		this.speedZ = speedZ*(0.5f);
		this.speed = speedZ*(0.5f);
	}

	public GameObject getGameObject(){
		return gameObject;
	}



	public void moveTo(float x,float y) {
		playerTransform.position = new Vector3 (x, y, playerTransform.position.z);

	}
}
