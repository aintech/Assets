using UnityEngine;
using System.Collections;

public class HullScript : MonoBehaviour {

	public Sprite[] hulls;

	private HullType hullType;

	private SpriteRenderer renderer;

	private int protection;

	void Awake () {
		if (renderer == null) renderer = transform.GetComponent<SpriteRenderer>();
	}

	public void setHull (HullType hullType) {
		this.hullType = hullType;
		switch (hullType) {
		case HullType.Little: 		renderer.sprite = hulls[0]; break;
		case HullType.Mouse: 		renderer.sprite = hulls[1]; break;
		case HullType.Cricket: 		renderer.sprite = hulls[2]; break;
		case HullType.Needle: 		renderer.sprite = hulls[3]; break;
		case HullType.Argo: 		renderer.sprite = hulls[4]; break;
		case HullType.Falcon: 		renderer.sprite = hulls[5]; break;
		case HullType.Adventurer: 	renderer.sprite = hulls[6]; break;
		case HullType.Corvette: 	renderer.sprite = hulls[7]; break;
		case HullType.Buffalo: 		renderer.sprite = hulls[8]; break;
		case HullType.Legionnaire: 	renderer.sprite = hulls[9]; break;
		case HullType.StarWalker: 	renderer.sprite = hulls[10]; break;
		case HullType.Warship: 		renderer.sprite = hulls[11]; break;
		case HullType.Asterix: 		renderer.sprite = hulls[12]; break;
		case HullType.Prime: 		renderer.sprite = hulls[13]; break;
		case HullType.Titan: 		renderer.sprite = hulls[14]; break;
		case HullType.Dreadnaut: 	renderer.sprite = hulls[15]; break;
		case HullType.Armageddon:	renderer.sprite = hulls[16]; break;
		default: Debug.Log("Неизвестный тип корпуса");
		}
		setRandomProtection ();
	}

	public void setHull (HullType hullType, int protection) {
		setHull(hullType);
		this.protection = protection;
	}

	private void setRandomProtection () {
		float seed = Mathf.Round(hullType.getProtection() / 3);
		protection = (int) Random.Range(protection - seed, protection + seed);
	}

	public int getProtection () {
		return protection;
	}
}
