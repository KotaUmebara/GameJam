using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWater : MonoBehaviour
{
    // ��������v���n�u�i�[�p
    public GameObject PrefabWater1;
    public GameObject PrefabWater2;
    //��x�������s
    private bool first;
    //�X�C�J�̊p�x
    private float angle;
    void Start()
    {
        first = false;
        angle=28.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //���߂̈�񂾂��v���n�u�𐶐�
        if (first == false)
        {
            // �v���n�u�̈ʒu�������_���Őݒ�
            float x1 = Random.Range(-5.0f, 5.0f);
            float x2 = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x1, 1.47f, 5.02f);
            Vector3 pos2 = new Vector3(x2, 3.76f, -21.25f);

            // �v���n�u�𐶐�
            Instantiate(PrefabWater1, pos1, Quaternion.Euler(0, 0, angle));
            Instantiate(PrefabWater2, pos2, Quaternion.Euler(0, 0, -angle));
            first = true;
        }
    }
}
