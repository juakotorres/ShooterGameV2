using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public GameObject player;
    public GameObject minions;
    private float myVelocity;
    private Rigidbody myBody;
    private float delta;
    private float accumulator;
    private float missileTime;

    // Use this for initialization
    void Start () {
        myVelocity = 10f;
        delta = -0.1f;
        myBody = GetComponent<Rigidbody>();
        accumulator = 0f;
        missileTime = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
        myBody.velocity = new Vector3(myVelocity, 0, 0);
        accumulator = accumulator + Time.deltaTime;

        if (accumulator > missileTime)
        {
            accumulator = 0f;
            if (Vector3.Distance(player.transform.transform.position, transform.position) < 10)
            {
                Vector3 pos = transform.localPosition + new Vector3(0, 2, 0);
                Instantiate(minions, pos, Quaternion.identity);
            }
        }
        if (myVelocity < -10)
        {
            delta = 0.1f;
        } else if(myVelocity > 10)
        {
            delta = -0.1f;
        }

        myVelocity = myVelocity + delta;
	}
}
