using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFix : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        Transform myTransform = this.transform;

        // ワールド座標を基準に、回転を取得
        Vector3 worldAngle = myTransform.eulerAngles;
        worldAngle.x = 0.0f; // ワールド座標を基準に、x軸を軸にした回転を10度に変更
        worldAngle.y = 90.0f; // ワールド座標を基準に、y軸を軸にした回転を10度に変更
        myTransform.eulerAngles = worldAngle; // 回転角度を設定
    }
}
