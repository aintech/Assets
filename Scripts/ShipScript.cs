using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

	private Transform hull;
	private Transform engine;

	private HullScript hullScript;
	private EngineScript engineScript;
	private ShipController controller;

	void Awake () {
		if (hull == null && engine == null) {
			hull = GameObject.Find("Hull").transform;
			engine = GameObject.Find("Engine").transform;
			hullScript = hull.GetComponent<HullScript>();
			engineScript = engine.GetComponent<EngineScript>();
			controller = transform.GetComponent<ShipController>();
		}
	}

	public void initShip (HullType hullType, EngineType engineType, bool isPlayerShip) {
		hullScript.setHull(hullType);
		engineScript.setEngine(engineType);
		if (isPlayerShip) controller.initController(this);
	}

	public HullScript getHullsScript () {
		return hullScript;
	}

	public EngineScript getEngineScript () {
		return engineScript;
	}
}
