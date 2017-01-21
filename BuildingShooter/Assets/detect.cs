using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect : MonoBehaviour {

    public GameObject player;
    public GameObject enemies;
    private LightManager scrips;

    // Use this for initialization
    void Start () {
        scrips = GetComponentInChildren<LightManager>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(player.transform.transform.position, transform.position) < 4 ||
            Vector3.Distance(enemies.transform.transform.position, transform.position) < 4)
        {
            scrips.TurnOn();
        } else
        {
            scrips.TurnOff();
        }
    }
}
