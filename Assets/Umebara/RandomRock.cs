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
    private bool first;
    void Start()
    {
        first = false;
    }
    void Update()
    {
        //初めの一回だけプレハブを生成
        if (first == false)
        {
            // プレハブの位置をランダムで設定
            float x1 = Random.Range(-5.0f, 5.0f);
            float x2 = Random.Range(-5.0f, 5.0f);
            float x3 = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x1, 1.37f, -10.11f);
            Vector3 pos2 = new Vector3(x2, -0.76f, 12.1f);
            Vector3 pos3 = new Vector3(x3, -1.74f, 24.06f);

            // プレハブを生成
            Instantiate(PrefabRock1, pos1, Quaternion.identity);
            Instantiate(PrefabRock2, pos2, Quaternion.identity);
            Instantiate(PrefabRock3, pos3, Quaternion.identity);
            first = true;
        }
    }
}
