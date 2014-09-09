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
		case EngineType.Force: return 1f;
		case EngineType.Gradual: return 2f;
		case EngineType.Proton: return 3f;
		case EngineType.Allur: return 4f;
		case EngineType.Quazar: return 5f;
		default: return 0;
		}
	}

	public static float getRotatePower (this EngineType type) {
		switch(type) {
		case EngineType.Force: return 0.5f;
		case EngineType.Gradual: return 1f;
		case EngineType.Proton: return 1.5f;
		case EngineType.Allur: return 2f;
		case EngineType.Quazar: return 2.5f;
		default: return 0;
		}
	}
}