using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTransition : MonoBehaviour {
	public List<Sprite> walkingSprites;
	public float timeLapse;
	private SpriteTransition spriteTransition;
	private SpriteRenderer spriteRenderer;
	private int currentSpritePosition;

	private void Start() {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		currentSpritePosition = 0;
		spriteRenderer.sprite = walkingSprites [currentSpritePosition];
		currentSpritePosition++;
		timeLapse = 0.4f;
	}

	private void Update() {
		timeLapse -= Time.deltaTime;
		if (timeLapse <= 0) {
			spriteRenderer.sprite = walkingSprites [currentSpritePosition];
			currentSpritePosition = (currentSpritePosition + 1) % walkingSprites.Count;
			timeLapse = 0.4f;
		}
	}


}
