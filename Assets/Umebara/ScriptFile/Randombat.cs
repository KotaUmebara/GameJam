using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Randombat : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabBat1;
    public GameObject PrefabBat2;
    public GameObject PrefabBat3;
    public GameObject PrefabBat4;
    //一度だけ実行
    private bool first;
    //角度の調整
    private float Zangle;
    void Start()
    {
        first = false;
        Zangle = 88.5f;
    }
    void Update()
    {
        //初めの一回だけプレハブを生成
        if (first == false)
        {
            // プレハブの位置をランダムで設定
            float x1 = Random.Range(-4.0f, 4.0f);
            float x2 = Random.Range(-4.0f, 4.0f);
            float x3 = Random.Range(-4.0f, 4.0f);
            float x4 = Random.Range(-4.0f, 4.0f);
            Vector3 pos1 = new Vector3(x1, 0.51f, -3.38f);
            Vector3 pos2 = new Vector3(x2, -2.66f, 32.92f);
            Vector3 pos3 = new Vector3(x3, -1.34f, 18.09f);
            Vector3 pos4 = new Vector3(x4, -3.10f, 38.40f);

            // プレハブを生成
            Instantiate(PrefabBat1, pos1, Quaternion.Euler(0, 0, Zangle));
            Instantiate(PrefabBat2, pos2, Quaternion.Euler(0, 0, -Zangle));
            Instantiate(PrefabBat3, pos3, Quaternion.Euler(0, 0, Zangle));
            Instantiate(PrefabBat4, pos4, Quaternion.Euler(0, 0, Zangle));
            first = true;
        }
    }
}
