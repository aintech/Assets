using UnityEngine;
using System.Collections;

public enum EngineType {
	Force,
	Gradual,
	Proton,
	Allur,
	Quazar
}

public static class Engine {
	public static string getName (this EngineType type) {
		switch(type) {
		case EngineType.Force: return "Силовой";
		case EngineType.Gradual: return "Поступательный";
		case EngineType.Proton: return "Протонный";
		case EngineType.Allur: return "Аллюровый";
		case EngineType.Quazar: return "Квазарный";
		default: return "Неизвестный тип двигателя";
		}
	}

	public static float getMainPower (this EngineType type) {
		switch(type) {
		case EngineType.Force: return 0.25f;
		case EngineType.Gradual: return 0.35f;
		case EngineType.Proton: return 0.5f;
		case EngineType.Allur: return 0.75f;
		case EngineType.Quazar: return 1f;
		default: return 0;
		}
	}

	public static float getRotatePower (this EngineType type) {
		switch(type) {
		case EngineType.Force: return 4f;
		case EngineType.Gradual: return 6f;
		case EngineType.Proton: return 9f;
		case EngineType.Allur: return 12f;
		case EngineType.Quazar: return 15f;
		default: return 0;
		}
	}
}