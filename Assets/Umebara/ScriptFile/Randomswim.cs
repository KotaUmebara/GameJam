using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomswim : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabSwim1;
    //一度だけ実行
    private bool first;
    //浮き輪の角度
    private float angle;
    void Start()
    {
        first = false;
        angle = -83.7f;
    }
    void Update()
    {
        //初めの一回だけプレハブを生成
        if (first == false)
        {
            // プレハブの位置をランダムで設定
            float x1 = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x1, -3.45f, 42.04f);

            // プレハブを生成
            Instantiate(PrefabSwim1, pos1, Quaternion.Euler(angle, 0, 0));
            first = true;
        }
    }
}
