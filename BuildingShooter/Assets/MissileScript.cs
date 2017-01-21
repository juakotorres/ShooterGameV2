using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileScript : MonoBehaviour {
    
    private float playerx;
    private float playery;
    private float playerz;
    private GameObject terrain;
    private GameObject player;
    private float accumulator;
    private float TTL;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
        playerx = player.transform.position.x;
        playery = player.transform.position.y;
        playerz = player.transform.position.z;
        terrain = GameObject.Find("Terrain");

        TTL = 3.0f;

    }

    // Update is called once per frame
    void Update() {

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(playerx, playery, playerz), 4 * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, terrain.transform.position.y + 1, transform.position.z);

        accumulator = accumulator + Time.deltaTime;

        if (accumulator >= TTL)
        {
            Destroy(gameObject);
        }

        if(Vector3.Distance(transform.position, player.transform.position) <= 1.1)
        {
            player.GetComponent<StatusBarPlayer>().Damage(10);
            Destroy(gameObject);
        }
    }
}
