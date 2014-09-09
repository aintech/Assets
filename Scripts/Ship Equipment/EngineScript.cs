using UnityEngine;
using System.Collections;

public class EngineScript : MonoBehaviour {

	public Sprite[] engines;

	private EngineType engineType;

	private SpriteRenderer engineRenderer;
	
	private float mainAcceleration;

	private float maxMainPower;

	private float maxBackwardPower;

	private float rotationAcceleration;

	private float maxRotationPower;

	void Awake () {
		if (engineRenderer == null) engineRenderer = transform.GetComponent<SpriteRenderer>();
	}

	public void setEngine (EngineType engineType) {
		this.engineType = engineType;
		switch (engineType) {
		case EngineType.Force: engineRenderer.sprite = engines[0]; break;
		case EngineType.Gradual: engineRenderer.sprite = engines[1]; break;
		case EngineType.Proton: engineRenderer.sprite = engines[2]; break;
		case EngineType.Allur: engineRenderer.sprite = engines[3]; break;
		case EngineType.Quazar: engineRenderer.sprite = engines[4]; break;
		}
		initEngine ();
	}

	private void initEngine () {
		switch (engineType) {
		case EngineType.STANDART:
			mainAcceleration = 0.01f;
			maxMainPower = 0.25f;
			maxBackwardPower = -0.25f;
			rotationAcceleration = 0.2f;
			maxRotationPower = 4.0f;
			break;
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
