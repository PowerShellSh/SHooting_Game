using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemyShip : MonoBehaviour
{
    public BossEnemyBullet bulletPrefab;
    void Start()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
