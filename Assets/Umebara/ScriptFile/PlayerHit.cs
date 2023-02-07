using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerHit : MonoBehaviour
{
    //正誤判定
    private bool change;
    //Playerの格納
    GameObject Player;
    // 生成するプレハブ格納用
    public GameObject explosion;
    Vector3 pos;
    void Start()
    {
        change = false;
        //Playerの取得
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Player != null)
        {
            // transformを取得
            Transform PlayerTransform = this.Player.transform;
            // 座標を取得
            Vector3 pos = PlayerTransform.position;
        }
        if (change == true)
        {
            Destroy(Player);
            change = false;
            // プレハブを生成
            Instantiate(explosion, pos, Quaternion.identity);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "Player")
        {
            // 正誤の切り替え
            change = true;
        }
    }
}
