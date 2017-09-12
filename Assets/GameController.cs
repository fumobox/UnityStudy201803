using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	Text scoreText;

	[SerializeField]
	GameObject gameOverPanel;

	int score;

	public int Score { 
		get {
			return score;
		}
		set	{
			score = value;
			scoreText.text =  "スコア " + score;
		}
	}

	public void GameOver()
	{
		StartCoroutine (GameOverCoroutine ());
	}

	IEnumerator GameOverCoroutine()
	{
		gameOverPanel.SetActive (true);
		yield return new WaitForSeconds (5f);

		SceneManager.LoadScene ("Title");
		int highScore = PlayerPrefs.GetInt ("highscore", 0);
		if(score > highScore)
			PlayerPrefs.SetInt ("highscore", score);
	}

	// テストコード
//	void Update() {
//		Score++;
//	}

}
