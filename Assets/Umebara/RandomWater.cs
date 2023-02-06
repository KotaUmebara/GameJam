using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWater : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabWater1;
    public GameObject PrefabWater2;
    //一度だけ実行
    private bool first;
    void Start()
    {
        first = false;
    }

    // Update is called once per frame
    void Update()
    {
        //初めの一回だけプレハブを生成
        if (first == false)
        {
            // プレハブの位置をランダムで設定
            float x1 = Random.Range(-5.0f, 5.0f);
            float x2 = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x1, 5.0f, 5.0f);
            Vector3 pos2 = new Vector3(x2, 5.0f, 10.0f);

            // プレハブを生成
            Instantiate(PrefabWater1, pos1, Quaternion.identity);
            Instantiate(PrefabWater2, pos2, Quaternion.identity);
            first = true;
        }
    }
}
