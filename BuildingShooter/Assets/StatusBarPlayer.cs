using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatusBarPlayer : MonoBehaviour {

    float health;

	// Use this for initialization
	void Start () {
        health = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void Damage(float damage)
    {
        health -= damage;

        if(health < 0)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
