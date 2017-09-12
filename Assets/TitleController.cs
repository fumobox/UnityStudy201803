using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour {

	[SerializeField]
	Text scoreText;

	void Start() {
		// ハイスコアを読み込む。
		int highScore = PlayerPrefs.GetInt ("highscore", 0);
		scoreText.text =  "ハイスコア " + highScore;
	}

	public void StartGame()
	{
		// ゲームシーンに移動する。
		SceneManager.LoadScene ("Game");
	}
}
