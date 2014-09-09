using UnityEngine;
using System.Collections;

public enum ShieldType {
	Block,
	Quadratic,
	Cell,
	Phase
}

public static class Shield {
	public static string getName (this ShieldType type) {
		switch(type) {
		case ShieldType.Block: return "Блочный";
		case ShieldType.Quadratic: return "Квадратичный";
		case ShieldType.Cell: return "Ячеестый";
		case ShieldType.Phase: return "Фазовый";
		default: return "Неизвестный тип щита";
		}
	}
	
	public static int getShieldLevel (this ShieldType type) {
		switch(type) {
		case ShieldType.Block: return 100;
		case ShieldType.Quadratic: return 150;
		case ShieldType.Cell: return 200;
		case ShieldType.Phase: return 300;
		default: return 0;
		}
	}
}