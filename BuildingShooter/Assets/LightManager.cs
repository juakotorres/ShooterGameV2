using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour {

    public Light lucesita;
    public GameObject  imagen;
    private SpriteRenderer render;

	// Use this for initialization
	void Start () {
        render = imagen.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.X))
            TurnOn();

        if (Input.GetKey(KeyCode.Z))
            TurnOff();
    }


    public void TurnOn()
    {
        render.enabled = true;
        lucesita.intensity = 0.1F;
    }


    public void TurnOff()
    {
        render.enabled = false;
        lucesita.intensity = 0.00F;
    }
}
