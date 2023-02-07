using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomGoal : MonoBehaviour
{
    // 生成するプレハブ格納用
    public GameObject PrefabBrige;
    public GameObject PrefabCy;
    //正誤判定
    private bool first;
    //Playerの格納
    [SerializeField] GameObject Player;
    void Start()
    {
        first = false;
        //Playerの取得
        Player = GameObject.Find("Player");
    }
    void Update()
    {
        if(Player!= null)
        {
            // transformを取得
            Transform PlayerTransform = this.Player.transform;
            // 座標を取得
            Vector3 pos = PlayerTransform.position;
            //筒と橋を設置
            if (pos.z >= 50.0f && first == false)
            {
                //Playerの位置に合わせて
                Vector3 pos1 = new Vector3(pos.x, -4.42f, 54.75f);
                Vector3 pos2 = new Vector3(pos.x, -7.87f, 60.4f);

                // プレハブを生成
                Instantiate(PrefabBrige, pos1, Quaternion.identity);
                Instantiate(PrefabCy, pos2, Quaternion.identity);
                first = true;
            }
        }
    }
}
