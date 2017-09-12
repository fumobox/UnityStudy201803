using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	void Update()
	{
		transform.Translate(Vector3.down * 0.05f); // 下方向に移動させる
	}

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
		GameObject.Find ("Game").GetComponent<GameController> ().Score++;
    }
}
