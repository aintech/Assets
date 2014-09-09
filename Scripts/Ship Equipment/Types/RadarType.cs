using UnityEngine;
using System.Collections;

public enum RadarType {
	Sequester,
	Planar,
	Matrix,
	PatanCorsac,
	Snake,
	Astral
}

public static class Radar {
	public static string getName (this RadarType type) {
		switch(type) {
		case RadarType.Sequester: return "Секвесторный";
		case RadarType.Planar: return "Планарный";
		case RadarType.Matrix: return "Матричный";
		case RadarType.PatanCorsac: return "Патан-Корсака";
		case RadarType.Snake: return "Змеевой";
		case RadarType.Astral: return "Астральный";
		default: return "Неизвестный тип радара";
		}
	}
	
	public static int getRange (this RadarType type) {
		switch(type) {
		case RadarType.Sequester: return 100;
		case RadarType.Planar: return 150;
		case RadarType.Matrix: return 200;
		case RadarType.PatanCorsac: return 300;
		case RadarType.Snake: return 400;
		case RadarType.Astral: return 600;
		default: return 0;
		}
	}
}