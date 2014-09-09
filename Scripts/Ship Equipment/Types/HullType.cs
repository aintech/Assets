using UnityEngine;
using System.Collections;

public enum HullType {
	Little,
	Mouse,
	Cricket,
	Needle,
	Argo,
	Falcon,
	Adventurer,
	Corvette,
	Buffalo,
	Legionnaire,
	StarWalker,
	Warship,
	Asterix,
	Prime,
	Titan,
	Dreadnaut,
	Armageddon
}

public static class Hull {
	public static string getName (this HullType type) {
		switch(type) {
		case HullType.Little: return "Малютка";
		case HullType.Mouse: return "Мышь";
		case HullType.Cricket: return "Сверчёк";
		case HullType.Needle: return "Игла";
		case HullType.Argo: return "Арго";
		case HullType.Falcon: return "Фалкон";
		case HullType.Adventurer: return "Авантюрист";
		case HullType.Corvette: return "Корвет";
		case HullType.Buffalo: return "Буйвол";
		case HullType.Legionnaire: return "Легионер";
		case HullType.StarWalker: return "Звёздоход";
		case HullType.Warship: return "Воршип";
		case HullType.Asterix: return "Астерикс";
		case HullType.Prime: return "Прайм";
		case HullType.Titan: return "Титан";
		case HullType.Dreadnaut: return "Дреднаут";
		case HullType.Armageddon: return "Армагеддон";
		default: return "Неизвестный тип корпуса";
		}
	}

	public static int getHullClass (this HullType type) {
		switch(type) {
		case HullType.Little:
		case HullType.Mouse:
		case HullType.Cricket:
		case HullType.Needle: return 1;
		case HullType.Argo:
		case HullType.Falcon:
		case HullType.Adventurer:
		case HullType.Corvette: return 2;
		case HullType.Buffalo:
		case HullType.Legionnaire:
		case HullType.StarWalker:
		case HullType.Warship:
		case HullType.Asterix: return 3;
		case HullType.Prime:
		case HullType.Titan:
		case HullType.Dreadnaut:
		case HullType.Armageddon: return 4;
		default: return 0;
		}
	}

	public static int getAvailableWeaponSlots (this HullType type) {
		switch(type) {
		case HullType.Little:		return 0;
		case HullType.Mouse: 		return 0;
		case HullType.Cricket: 		return 1;
		case HullType.Needle: 		return 1;
		case HullType.Argo: 		return 1;
		case HullType.Falcon: 		return 1;
		case HullType.Adventurer: 	return 2;
		case HullType.Corvette: 	return 2;
		case HullType.Buffalo: 		return 2;
		case HullType.Legionnaire: 	return 3;
		case HullType.StarWalker: 	return 3;
		case HullType.Warship: 		return 4;
		case HullType.Asterix: 		return 4;
		case HullType.Prime: 		return 4;
		case HullType.Titan: 		return 5;
		case HullType.Dreadnaut: 	return 5;
		case HullType.Armageddon: 	return 6;
		default: return 0;
		}
	}

	public static int getProtection (this HullType type) {
		switch(type) {
		case HullType.Little:		return 5;
		case HullType.Mouse: 		return 10;
		case HullType.Cricket: 		return 12;
		case HullType.Needle: 		return 15;
		case HullType.Argo: 		return 30;
		case HullType.Falcon: 		return 40;
		case HullType.Adventurer: 	return 45;
		case HullType.Corvette: 	return 55;
		case HullType.Buffalo: 		return 80;
		case HullType.Legionnaire: 	return 90;
		case HullType.StarWalker: 	return 105;
		case HullType.Warship: 		return 120;
		case HullType.Asterix: 		return 140;
		case HullType.Prime: 		return 200;
		case HullType.Titan: 		return 250;
		case HullType.Dreadnaut: 	return 320;
		case HullType.Armageddon: 	return 380;
		default: return 0;
		}
	}
}