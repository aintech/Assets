using UnityEngine;
using System.Collections;

public class EngineScript : MonoBehaviour {

	public Sprite[] engines;

	private EngineType engineType;

	private SpriteRenderer engineRenderer;
	
	private float mainAcceleration = 0.01f;
	
	private float rotationAcceleration = 0.2f;

	private float maxMainPower;

	private float maxBackwardPower;

	private float maxRotationPower;

	void Awake () {
		if (engineRenderer == null) engineRenderer = transform.GetComponent<SpriteRenderer>();
	}

	public void setEngine (EngineType engineType) {
		setEngine(engineType, getRandomMainPower (engineType), getRandomRotatePower (engineType));
	}

	public void setEngine (EngineType engineType, float maxMainPower, float maxRotationPower) {
		this.engineType = engineType;
		this.maxMainPower = maxMainPower;
		this.maxBackwardPower = -maxMainPower;
		this.maxRotationPower = maxRotationPower;
		setSprite ();
	}
	
	private float getRandomMainPower (EngineType engineType) {
		return Utils.getRandomValue (engineType.getMainPower(), 3);
	}
	
	private float getRandomRotatePower (EngineType engineType) {
		return Utils.getRandomValue (engineType.getRotatePower(), 3);
	}

	private void setSprite () {
		switch (engineType) {
		case EngineType.Force: engineRenderer.sprite = engines[0]; break;
		case EngineType.Gradual: engineRenderer.sprite = engines[1]; break;
		case EngineType.Proton: engineRenderer.sprite = engines[2]; break;
		case EngineType.Allur: engineRenderer.sprite = engines[3]; break;
		case EngineType.Quazar: engineRenderer.sprite = engines[4]; break;
		}
	}

	public float getMainAcceleration () {
		return mainAcceleration;
	}

	public float getMaxMainPower () {
		return maxMainPower;
	}

	public float getMaxBackwardPower () {
		return maxBackwardPower;
	}

	public float getRotationAcceleration () {
		return rotationAcceleration;
	}

	public float getMaxRotationPower () {
		return maxRotationPower;
	}
}
