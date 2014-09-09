using UnityEngine;
using System.Collections;

public enum RepairDroidType {
	Rail,
	Channel,
	Biphasic,
	Thread
}

public static class RepairDroid {
	public static string getName (this RepairDroidType type) {
		switch(type) {
		case RepairDroidType.Rail: return "Рельсовый";
		case RepairDroidType.Channel: return "Канальный";
		case RepairDroidType.Biphasic: return "Бифазный";
		case RepairDroidType.Thread: return "Поточный";
		default: return "Неизвестный тип дроида-ремонтника";
		}
	}
	
	public static float getRepairSpeed (this RepairDroidType type) {
		switch(type) {
		case RepairDroidType.Rail: return 2;
		case RepairDroidType.Channel: return 5;
		case RepairDroidType.Biphasic: return 10;
		case RepairDroidType.Thread: return 25;
		default: return 0;
		}
	}
}