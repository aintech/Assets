using UnityEngine;
using System.Collections;

public abstract class WeaponScript : MonoBehaviour {

	private WeaponType weaponType;

	protected Animator anim;

	protected float timeForReloading;

	protected float reloadingSpeed;

	protected float currentReloadTime;

	protected bool shotButtonIsPressed;

	private Transform mainCamera;

	private Vector3 mousePosition;

	float mouseToWeaponX;

	float mouseToWeaponY;

	float degreeMouseToWeapon;

	Vector3 weaponRotation = new Vector3();

	private void Awake () {
		if (anim == null) {
			anim = GetComponent<Animator>();
			mainCamera = Camera.main.transform;
		}
		init();
	}

	abstract protected void init ();

	private void Update () {
		shotButtonIsPressed = Input.GetMouseButton(0);
	}

	private void FixedUpdate () {
		weaponFollowShipAndLookAtMouse();
		reloadWeapon();
	}

	private void weaponFollowShipAndLookAtMouse () {
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mouseToWeaponX = mousePosition.x - transform.position.x;
		mouseToWeaponY = mousePosition.y - transform.position.y;
		degreeMouseToWeapon = Mathf.Atan2(mouseToWeaponY, mouseToWeaponX) * Mathf.Rad2Deg;
		degreeMouseToWeapon -= (degreeMouseToWeapon >= 360) ? 270 : 90;
		weaponRotation.z = degreeMouseToWeapon - transform.rotation.eulerAngles.z;
		transform.Rotate(weaponRotation);
	}

	abstract protected void reloadWeapon ();

	protected void setWeaponType (WeaponType weaponType) {
		this.weaponType = weaponType;
	}

	public WeaponType getWeaponType () {
		return weaponType;
	}
}