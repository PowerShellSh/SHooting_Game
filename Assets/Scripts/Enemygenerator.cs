using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//　生成する位置x座標をランダムにしたい
public class Enemygenerator : MonoBehaviour
{
    public GameObject enemyPrefab;
    //敵を左右に揺らせる
    //スコアの表示
    //敵を倒したときにスコアを上昇させる
    //リスタートの実装
    void Start()
    {
        //Spawn関数を、2秒後に0.5刻みで実行する
        InvokeRepeating("Spawn", 2f, 0.5f);
    }
    //生成する
    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-2.5f, 2.5f),
            transform.position.y,
            transform.position.z
            );
        Instantiate(
            enemyPrefab,        //生成するオブジェクト
            spawnPosition,      //生成位置
            transform.rotation  //生成時の向き
            );

    }

    void Update()
    {
        
    }
}
