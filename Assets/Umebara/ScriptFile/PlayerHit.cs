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
    //SE関連
    public GameObject explosion;
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        change = false;
        //Playerの取得
        Player = GameObject.Find("Player");
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (change == true)
        {
            // transformを取得
            Transform PlayerTransform = this.Player.transform;
            // 座標を取得
            Vector3 pos = PlayerTransform.position;
            Destroy(Player);
            change = false;
            //爆発エフェクトの一調整
            pos.y += 0.8f;
            pos.z -= 0.05f;
            // プレハブを生成
            Instantiate(explosion, pos, Quaternion.identity);
            audioSource.PlayOneShot(sound1);
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
