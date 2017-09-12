using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour {

	public GameObject enemyPrefab;
	private float timer;

	void Update()
	{
		timer += Time.deltaTime;
		if (timer >= 1f) // タイマーが1秒経過していたら
		{
			Create(); // 敵を生成
			timer = 0f; // タイマーを初期化する
		}
	}

	void Create()
	{
		var obj = Instantiate(enemyPrefab); // プレハブから敵のオブジェクトを生成
		var x = Random.Range(-5f, 5f); // -5f ～ 5f の間でランダムな値を取得
		obj.transform.position = new Vector3(x, 5f, 0f); // 敵の位置を設定
		Destroy(obj, 5f); // 5秒後に自動的に破棄する
	}

}
