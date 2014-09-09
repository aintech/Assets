using UnityEngine;
using System.Collections;

public enum WeaponType {
	Blaster,
	Plasmer,
	Charger,
	Emitter,
	Waver,
	Launcher,
	Suppressor
}

public static class Weapon {
	public static string getName (this WeaponType type) {
		switch(type) {
		case WeaponType.Blaster: return "Бластер";
		case WeaponType.Plasmer: return "Плазмер";
		case WeaponType.Charger: return "Разрядник";
		case WeaponType.Emitter: return "Излучатель";
		case WeaponType.Waver: return "Волноход";
		case WeaponType.Launcher: return "Ракетница";
		case WeaponType.Suppressor: return "Подавитель";
		default: return "Неизвестная категория оружия";
		}
	}

	public static string getDescription (this WeaponType type) {
		switch(type) {
		case WeaponType.Blaster:
			return "Стреляет заряженными частицами.\n" +
				"Стандартное оружие заменившее огнестрельное, встречается повсеместно и в " +
				"совершенно разных исполнениях, его можно обнаружить и на боевом корабле и в " +
				"сумочке пожилой леди.";
		case WeaponType.Plasmer:
			return "Стреляет сгустками плазмы.";
		case WeaponType.Charger:
			return "Создает электрический 'луч'.";
		case WeaponType.Emitter:
			return "Луч антиматерии, пронзающий всё на своём пути";
		case WeaponType.Waver:
			return "Стреляет полукругом энергии с затуханием (навроде дробовика)";
		case WeaponType.Launcher:
			return "Запускает небольшие сгустки энергии взрывающиеся при соприкосновении";
		case WeaponType.Suppressor:
			return "Снижает скорость движения и атаки врага";
		default: return "Неизвестная категория оружия";
		}
	}
}