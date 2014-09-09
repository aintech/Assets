using UnityEngine;
using System.Collections;

public enum HarvestDroidType {
	Mechanical,
	Plasmatic,
	Generative
}

public static class HarvestDroid {
	public static string getName (this HarvestDroidType type) {
		switch(type) {
		case HarvestDroidType.Mechanical: return "Механический";
		case HarvestDroidType.Plasmatic: return "Плазматический";
		case HarvestDroidType.Generative: return "Генеративный";
		default: return "Неизвестный тип дроида-сборщика";
		}
	}
	
	public static float getSpeed (this HarvestDroidType type) {
		switch(type) {
		case HarvestDroidType.Mechanical: return 1f;
		case HarvestDroidType.Plasmatic: return 2f;
		case HarvestDroidType.Generative: return 3f;
		default: return 0f;
		}
	}

	public static int getMaxVolume (this HarvestDroidType type) {
		switch(type) {
		case HarvestDroidType.Mechanical: return 100;
		case HarvestDroidType.Plasmatic: return 200;
		case HarvestDroidType.Generative: return 300;
		default: return 0;
		}
	}
}
