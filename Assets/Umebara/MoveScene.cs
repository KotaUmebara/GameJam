using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    //正誤判定
    private bool change;
    void Start()
    {
        change = false;

    }

    void Update()
    {
        //正誤が切り替わったらシーン遷移
        if (change == true)
        {
            SceneManager.LoadScene("GoalScene");
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
