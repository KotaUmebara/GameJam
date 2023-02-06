using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGoal : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabBrige;
    public GameObject PrefabCy;
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
            float x = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x, -4.42f, 54.75f);
            Vector3 pos2 = new Vector3(x, -7.05f, 60.4f);

            // プレハブを生成
            Instantiate(PrefabBrige, pos1, Quaternion.identity);
            Instantiate(PrefabCy, pos2, Quaternion.identity);
            first = true;
        }
    }
}
