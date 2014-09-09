using UnityEngine;
using System.Collections;

public enum ArmorType {
	Steel,
	HardenedSteel,
	Titan,
	Astron,
	Adamant
}

public static class Armor {
	public static string getName (this ArmorType type) {
		switch(type) {
		case ArmorType.Steel: return "Сталь";
		case ArmorType.HardenedSteel: return "Усиленная сталь";
		case ArmorType.Titan: return "Титан";
		case ArmorType.Astron: return "Астроний";
		case ArmorType.Adamant: return "Адамантий";
		default: return "Неизвестный материал защиты корпуса";
		}
	}

	public static int getArmorClass (this ArmorType type) {
		switch(type) {
		case ArmorType.Steel: return 1;
		case ArmorType.HardenedSteel: return 2;
		case ArmorType.Titan: return 3;
		case ArmorType.Astron: return 4;
		case ArmorType.Adamant: return 5;
		default: return 0;
		}
	}
}