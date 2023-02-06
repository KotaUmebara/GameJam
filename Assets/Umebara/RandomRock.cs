using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class RandomRock : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabRock1;
    public GameObject PrefabRock2;
    public GameObject PrefabRock3;
    //一度だけ実行
    bool first;
    void Start()
    {
        first = false;
    }
    void Update()
    {
        // 30フレーム毎にシーンにプレハブを生成
        if (first == false)
        {
            // プレハブの位置をランダムで設定
            float x1 = Random.Range(-5.0f, 5.0f);
            float x2 = Random.Range(-5.0f, 5.0f);
            float x3 = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x1, 5.0f, 5.0f);
            Vector3 pos2 = new Vector3(x2, 5.0f, 10.0f);
            Vector3 pos3 = new Vector3(x3, 5.0f, 1.0f);

            // プレハブを生成
            Instantiate(PrefabRock1, pos1, Quaternion.identity);
            Instantiate(PrefabRock2, pos2, Quaternion.identity);
            Instantiate(PrefabRock3, pos3, Quaternion.identity);
            first = true;
        }
    }
}
