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

        // ���[���h���W����ɁA��]���擾
        Vector3 worldAngle = myTransform.eulerAngles;
        worldAngle.x = 0.0f; // ���[���h���W����ɁAx�������ɂ�����]��10�x�ɕύX
        worldAngle.y = 90.0f; // ���[���h���W����ɁAy�������ɂ�����]��10�x�ɕύX
        myTransform.eulerAngles = worldAngle; // ��]�p�x��ݒ�
    }
}
