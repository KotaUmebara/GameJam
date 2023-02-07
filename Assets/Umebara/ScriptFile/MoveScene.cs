using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    //正誤判定
    private bool change;
    //Playerの格納
    [SerializeField] GameObject Player;
    void Start()
    {
        change = false;
        //Playerの取得
        Player = GameObject.Find("Player");

    }

    void Update()
    {
        //正誤が切り替わったらシーン遷移
        if (change == true)
        {
            SceneManager.LoadScene("NewGoalScene");
            change = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "Player")
        {
            // 正誤の切り替え
            change= true;
        }
    }
}
