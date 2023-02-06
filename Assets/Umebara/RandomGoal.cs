using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGoal : MonoBehaviour
{
    // ��������v���n�u�i�[�p
    public GameObject PrefabBrige;
    public GameObject PrefabCy;
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
            float x = Random.Range(-5.0f, 5.0f);
            Vector3 pos1 = new Vector3(x, -4.42f, 54.75f);
            Vector3 pos2 = new Vector3(x, -7.05f, 60.4f);

            // �v���n�u�𐶐�
            Instantiate(PrefabBrige, pos1, Quaternion.identity);
            Instantiate(PrefabCy, pos2, Quaternion.identity);
            first = true;
        }
    }
}
