using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public Transform sectorPrefab;

	public Transform shipPrefab;

	private Transform playerShip;

	private Transform mainCamera;

	private ShipScript playerShipScript;

	private int currentSectorNumber;

	private Transform currentSector;

	private SectorScript currentSectorScript;
	
	private SectorScript[] localSectorsScripts = new SectorScript[9];

	//Выведеное опытным путем расстояние от центра до края сектора
	//при условии что разрешение картинки сектора 4096х4096, pixelsToUnit = 50, sectorMoveSpeed = 0.1
	private float sectorHalfSide = 409.1f;

	//Тот же опытный путь - высота картинки сектора
	private float sectorImageHeight = 81.9f;

	void Awake () {
		if (playerShip == null) {
			currentSector = Instantiate(sectorPrefab) as Transform;
			currentSector.name = "Center Sector";
			currentSectorScript = currentSector.GetComponent<SectorScript>();
			playerShip = Instantiate(shipPrefab) as Transform;
			playerShip.name = "Player Ship";
			playerShipScript = playerShip.GetComponent<ShipScript>();
			init();
		}
	}

	private void init () {
		playerShipScript.initShip(HullType.Argo, EngineType.Force, true);
		mainCamera = Camera.main.transform;
		mainCamera.GetComponent<CameraController>().init(playerShip);
		initSectors();
	}

	private void initSectors () {
		currentSectorScript.initSector(22, 0, 0);
		checkSectorWithCamera();
		currentSectorScript.setBackgroundImage(currentSectorNumber);
		localSectorsScripts[4] = currentSectorScript;
		initSectorsAround();
	}

	private void initSectorsAround () {
		for (int i = 0; i < localSectorsScripts.Length; i++) {
			if (i == 4) continue;
			Transform nearSector = Instantiate(sectorPrefab) as Transform;
			SectorScript script = nearSector.GetComponent<SectorScript>();
			localSectorsScripts[i] = script;
			int sectorLocalNum = 0;
			int sectorNum = 0;
			float moveOffsetX = 0;
			float moveOffsetY = 0;
			string sectorName = "";
			switch (i) {
				case 0: 
					sectorLocalNum = 11; 
					sectorNum = currentSectorNumber - 11;
					moveOffsetX = sectorImageHeight * -1;
					moveOffsetY = sectorImageHeight * -1;
					sectorName = "Lower Left Sector";
				break;
				case 1: 
					sectorLocalNum = 12;
					sectorNum = currentSectorNumber - 10;
					moveOffsetY = sectorImageHeight * -1;
					sectorName = "Lower Center Sector";
				break;
				case 2: 
					sectorLocalNum = 13;
					sectorNum = currentSectorNumber - 9;
					moveOffsetX = sectorImageHeight;
					moveOffsetY = sectorImageHeight * -1;
					sectorName = "Lower Right Sector";
				break;
				case 3: 
					sectorLocalNum = 21;
					sectorNum = currentSectorNumber - 1;
					moveOffsetX = sectorImageHeight * -1;
					sectorName = "Center Left Sector";
				break;
				case 5: 
					sectorLocalNum = 23;
					sectorNum = currentSectorNumber + 1;
					moveOffsetX = sectorImageHeight;
					sectorName = "Center Right Sector";
				break;
				case 6: 
					sectorLocalNum = 31;
					sectorNum = currentSectorNumber + 9;
					moveOffsetX = sectorImageHeight * -1;
					moveOffsetY = sectorImageHeight;
					sectorName = "Upper Left Sector";
				break;
				case 7: 
					sectorLocalNum = 32;
					sectorNum = currentSectorNumber + 10;
					moveOffsetY = sectorImageHeight;
					sectorName = "Upper Center Sector";
				break;
				case 8: 
					sectorLocalNum = 33;
					sectorNum = currentSectorNumber + 11;
					moveOffsetX = sectorImageHeight;
					moveOffsetY = sectorImageHeight;
					sectorName = "Upper Right Sector";
				break;
			}
			script.initSector(sectorLocalNum, moveOffsetX, moveOffsetY);
			script.setBackgroundImage(sectorNum);
			nearSector.name = sectorName;
		}
	}

	void FixedUpdate () {
		//checkSectorWithCamera();
	}

	//Возвращает порядковый номер сектора от 11 до 55 (в котором находится камера)
	//Всего секторов 25, их порядок:
	//	51 52 53 54 55
	//	41 42 43 44 45
	//	31 32 33 34 35
	//	21 22 23 24 25
	//	11 12 13 14 15
	private void checkSectorWithCamera () {
		//порядковый номер сектора от левого края
		int fromLeft = (int)(mainCamera.position.x / sectorHalfSide) + 3;
		//порядковый номер сектора от нижнего края
		int fromBottom = (int)(mainCamera.position.y / sectorHalfSide) + 3;
		
		currentSectorNumber = (fromLeft * 10) + fromBottom;
	}
}
