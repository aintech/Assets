using UnityEngine;
using System.Collections;

public class PlanetScript : MonoBehaviour {

	private GameObject[] planets;

	void Awake () {
		planets = GameObject.FindGameObjectsWithTag("Planet");
		foreach (GameObject obj in planets) {
			if (!obj.name.ToLower().Equals(Variables.PLANET_TYPE.ToString().ToLower())) {
				obj.SetActive(false);
			}
		}
	}
}