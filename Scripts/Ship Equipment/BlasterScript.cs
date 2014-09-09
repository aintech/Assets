using UnityEngine;
using System.Collections;

public class BlasterScript : WeaponScript {

	override protected void init () {
		timeForReloading = 2.0f;
		reloadingSpeed = 0.1f;
		setWeaponType(WeaponType.Blaster);
	}

	override protected void reloadWeapon () {
		if (currentReloadTime < timeForReloading) {
			currentReloadTime += reloadingSpeed;
			anim.SetBool("shot", false);
		} else if (shotButtonIsPressed && currentReloadTime >= timeForReloading) {
			makeAShot();
			currentReloadTime = 0;
		}
	}

	private void makeAShot () {
		anim.SetBool("shot", true);
	}
}
