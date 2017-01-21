using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private float speedX;
	private float speedZ;
	private float xPosition;
	private float zPosition;
	private Rigidbody r;

	// Use this for initialization
	void Start () {
		r= gameObject.GetComponent<Rigidbody> ();
		xPosition = r.position.x;
		zPosition = r.position.z;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//r.velocity = new Vector3(speedX,0,speedZ);
		//r.AddForce(Vector3.up * -300.0f);
		xPosition += speedX*Time.fixedDeltaTime;
		zPosition += speedZ * Time.fixedDeltaTime;
		r.MovePosition (new Vector3(xPosition, r.transform.position.y, zPosition));
		//r.velocity.x = speedX;
		//r.velocity.z = speedZ;
		gameObject.transform.rotation = new Quaternion();
	}


	public void setSpeedX(float speedX) {
		this.speedX = speedX*(7.0f);
	}

	public void setSpeedZ(float speedZ) {
		this.speedZ = speedZ*(5.0f);
	}



}
