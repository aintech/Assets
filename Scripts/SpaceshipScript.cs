using UnityEngine;
using System.Collections;

public class SpaceshipScript : MonoBehaviour {

	private Transform hull;
	private Transform engine;

	private HullScript hullScript;
	private EngineScript engineScript;
	private ShipController controller;

	void Awake () {
		if (hull == null && engine == null) {
			hull = GameObject.Find("Hull").transform;
			engine = GameObject.Find("Engine").transform;
			hullScript = hull.GetComponent<ShipHullScript>();
			engineScript = engine.GetComponent<ShipEngineScript>();
			controller = transform.GetComponent<SpaceshipController>();
		}
	}

	public void initSpaceship (HullType hullType, EngineType engineType, bool isPlayerShip) {
		hullScript.setHull(hullType);
		engineScript.setEngine(engineType);
		if (isPlayerShip) controller.initController(this);
	}

	public getHullScript getHullsScript () {
		return hullScript;
	}

	public getEngineScript getEngineScript () {
		return engineScript;
	}
}
