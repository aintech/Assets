using UnityEngine;
using System.Collections;

public class PlanetViewScript : MonoBehaviour {

	public Texture2D handTexture;

	private int cursorSize = 32;

	Vector2 pos;

	private bool showHand;

	private Transform hangarArea;

	private Transform cityArea;

	private Transform marketArea;

	private BoxCollider2D hangarCollider;

	private BoxCollider2D cityCollider;

	private BoxCollider2D marketCollider;

	private BoxCollider2D currentChoise;

	private GUIText guiText;

	private float guiTextOffset = 0.04f;

	RaycastHit2D hit;

	void Awake () {
		hangarArea = transform.FindChild("HangarArea");
		cityArea = transform.FindChild("CityArea");
		marketArea = transform.FindChild("MarketArea");

		hangarCollider = hangarArea.GetComponent<BoxCollider2D>();
		cityCollider = cityArea.GetComponent<BoxCollider2D>();
		marketCollider = marketArea.GetComponent<BoxCollider2D>();

		guiText = transform.FindChild("Description").GetComponent<GUIText>();
		hideDescription ();
	}

	void Update () {
		hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if (hit.collider != null) {
			if (Screen.showCursor) {
				showDescription ();
				switch (hit.collider.name) {
				case "HangarArea": guiText.text = "Ангар"; break;
				case "CityArea": guiText.text = "Город"; break;
				case "MarketArea": guiText.text = "Рынок"; break;
				}
				currentChoise = (BoxCollider2D) hit.collider;
			}
		} else {
			if (!Screen.showCursor) {
				hideDescription ();
			}
		}
	}

	private void showDescription () {
		Screen.showCursor = false;
		showHand = true;
	}

	private void hideDescription () {
		Screen.showCursor = true;
		showHand = false;
		guiText.text = "";
		guiText.transform.position = new Vector3(2,2,0);
	}

	void OnGUI () {
		if (showHand) {
			pos = Event.current.mousePosition;
			GUI.DrawTexture(new Rect(pos.x - cursorSize*0.5f, pos.y - cursorSize*0.5f, cursorSize, cursorSize), handTexture);
			guiText.transform.position = new Vector3(pos.x / Screen.width, (Screen.height - pos.y) / Screen.height - guiTextOffset, guiText.transform.position.z);

			if (Input.GetMouseButtonDown(0)) {
				goToTarget ();
			}
		}
	}

	private void goToTarget () {
		//TODO создаём ангар
		Screen.showCursor = true;
		if (currentChoise == hangarCollider) {
			Application.LoadLevel("Hangar");
		} else if (currentChoise == marketCollider) {
			Application.LoadLevel("Market");
		} else if (currentChoise == cityCollider) {
			Debug.Log("Шо делать с Сити?");
		}
	}
}