using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate4 : MonoBehaviour
{
    public GameObject hanabiPrefab;
    //�p�x�����߂�ϐ�
    Quaternion rot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) //L�������Ɣ���
        {
            Instantiate(hanabiPrefab, this.transform.position, rot);
        }
    }
}
