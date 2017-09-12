using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject bulletPrefab;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            timer += Time.deltaTime;
            if (timer >= 0.2f)
            {
                Shot();
            }
        }
    }

    void Shot()
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.transform.position = transform.position + Vector3.up;
        Destroy(bullet, 3f);
        timer = 0f;
    }
}
