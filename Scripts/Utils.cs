using UnityEngine;
using System.Collections;

public static class Utils {

	private static float seed = 0;

	public static float getRandomValue (float value, float divider) {
		seed = value / divider;
		return Random.Range(value - seed, value + seed);
	}
}