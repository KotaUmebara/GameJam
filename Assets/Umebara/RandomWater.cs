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
    void Start()
    {
        first = false;
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
            Vector3 pos1 = new Vector3(x1, 5.0f, 5.0f);
            Vector3 pos2 = new Vector3(x2, 5.0f, 10.0f);

            // �v���n�u�𐶐�
            Instantiate(PrefabWater1, pos1, Quaternion.identity);
            Instantiate(PrefabWater2, pos2, Quaternion.identity);
            first = true;
        }
    }
}
