using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomswim : MonoBehaviour
{
    // ��������v���n�u�i�[�p
    public GameObject PrefabSwim1;
    //��x�������s
    private bool first;
    //�����ւ̊p�x
    private float angle;
    void Start()
    {
        first = false;
        angle = -83.7f;
    }
    void Update()
    {
        //���߂̈�񂾂��v���n�u�𐶐�
        if (first == false)
        {
            // �v���n�u�̈ʒu�������_���Őݒ�
            float x1 = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x1, -3.45f, 42.04f);

            // �v���n�u�𐶐�
            Instantiate(PrefabSwim1, pos1, Quaternion.Euler(angle, 0, 0));
            first = true;
        }
    }
}
