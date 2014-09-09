using UnityEngine;
using System.Collections;

public enum GeneratorType {
	Atomic,
	Plasma,
	Multyphase,
	Tunnel
}

public static class Generator {
	public static string getName (this GeneratorType type) {
		switch(type) {
		case GeneratorType.Atomic: return "Атомарный";
		case GeneratorType.Plasma: return "Плазменный";
		case GeneratorType.Multyphase: return "Мультифазный";
		case GeneratorType.Tunnel: return "Тунельный";
		default: return "Неизвестный тип генератора щита";
		}
	}
	
	public static int getShieldRechargeSpeed (this GeneratorType type) {
		switch(type) {
		case GeneratorType.Atomic: return 10;
		case GeneratorType.Plasma: return 15;
		case GeneratorType.Multyphase: return 25;
		case GeneratorType.Tunnel: return 40;
		default: return 0;
		}
	}

	public static int getMaxEnergy (this GeneratorType type) {
		switch(type) {
		case GeneratorType.Atomic: return 100;
		case GeneratorType.Plasma: return 200;
		case GeneratorType.Multyphase: return 300;
		case GeneratorType.Tunnel: return 400;
		default: return 0;
		}
	}
}