using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedObject : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject FPrefabRock1;
    public GameObject FPrefabRock2;
    public GameObject FPrefabRock3;
    public GameObject FPrefabSwim1;
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
            // プレハブの位置を設定
            Vector3 pos1 = new Vector3(-5.78f, -2.02f, 29.68f);
            Vector3 pos2 = new Vector3(-5.78f, 1.18f, 8.29f);
            Vector3 pos3 = new Vector3(5.71f, 1.15f, -7.04f);
            Vector3 pos4 = new Vector3(6.32f, -1.12f, 15.14f);

            // プレハブを生成
            Instantiate(FPrefabRock1, pos1, Quaternion.identity);
            Instantiate(FPrefabRock2, pos2, Quaternion.Euler(0, 0, -28.0f));
            Instantiate(FPrefabRock3, pos3, Quaternion.identity);
            Instantiate(FPrefabSwim1, pos4, Quaternion.Euler(-83.7f, 0, 0));
            first = true;
        }
    }
}
