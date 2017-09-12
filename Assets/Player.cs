using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	void OnDestroy()
	{
		GameObject.Find ("Game").GetComponent<GameController> ().GameOver();
	}

}
