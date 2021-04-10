using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  
/*
スコアの実装
・UIの作成
・UIの更新
・敵と弾がぶつかった時に更新
・Playerと弾の差別化:Tag

ゲームオーバーの実装
・UIを作成
・敵とPlayerがぶつかった時にUIを表示
・リトライも実装

　　・敵が左右に移動する
　　・Playerの移動範囲制御
　　・弾と敵の表示範囲
*/
public class GameController : MonoBehaviour
{
    public GameObject gameOverText;
    // UnityEngine.UI　classのTextプロパティを呼び出して「scoreText」というfeeldを作る
    public Text scoreText;
    int score = 0;
    void Start()
    {
        gameOverText.SetActive(false);
        scoreText.text = "SCORE:" + score;
        
    }

    private void Update()
    {
        if (gameOverText.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Main");
            }
        }
        
    }

    // スコア加算
    public void AddScore()
    {
        score += 100;
        scoreText.text = "SCORE:" + score;
    }

    // ゲームオーバー
    public void GameOver()
    {
        gameOverText.SetActive(true);
    }

}
