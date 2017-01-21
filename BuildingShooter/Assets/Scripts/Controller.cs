using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	public Player player;

	private float horizontalAxis;
	private float verticalAxis;

	private void Start() {
		player = gameObject.GetComponent<Player> ();
		horizontalAxis = 0;
		verticalAxis = 0;
	}

	private void Update() {
		horizontalAxis = Input.GetAxis ("Horizontal");
		verticalAxis = Input.GetAxis ("Vertical");
		player.setSpeedX (horizontalAxis); 
		player.setSpeedZ(verticalAxis);

	}
}
