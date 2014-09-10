using UnityEngine;
using System.Collections;

public class ArmorScript : MonoBehaviour {

	public Sprite[] armors;

	private ArmorType armorType;

	private SpriteRenderer renderer;

	private int armorClass;

	
	void Awake () {
		if (renderer == null) renderer = transform.GetComponent<SpriteRenderer>();
	}

	public void setArmor (ArmorType armorType) {
		setArmor(armorType, getRandomArmorClass (armorType));
	}

	public void setArmor (ArmorType armorType, int armorClass) {
		this.armorType = armorType;
		this.armorClass = armorClass;
		//setSprite ();
	}

	private int getRandomArmorClass (ArmorType armorType) {
		return (int) Mathf.Round(Utils.getRandomValue(armorType.getArmorClass(), 3));
	}

	private void setSprite () {
		switch (armorType) {
		case ArmorType.Steel: renderer.sprite = armors[0]; break;
		case ArmorType.HardenedSteel: renderer.sprite = armors[0]; break;
		case ArmorType.Titan: renderer.sprite = armors[0]; break;
		case ArmorType.Astron: renderer.sprite = armors[0]; break;
		case ArmorType.Adamant: renderer.sprite = armors[0]; break;
		default: Debug.Log("Неизвестный материал защиты корпуса"); break;
		}
	}

	public int getArmorClass () {
		return armorClass;
	}
}