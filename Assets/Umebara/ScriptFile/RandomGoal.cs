using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomGoal : MonoBehaviour
{
    // ��������v���n�u�i�[�p
    public GameObject PrefabBrige;
    public GameObject PrefabCy;
    //���딻��
    private bool first;
    //Player�̊i�[
    [SerializeField] GameObject Player;
    void Start()
    {
        first = false;
        //Player�̎擾
        Player = GameObject.Find("Player");
    }
    void Update()
    {
        if(Player!= null)
        {
            // transform���擾
            Transform PlayerTransform = this.Player.transform;
            // ���W���擾
            Vector3 pos = PlayerTransform.position;
            //���Ƌ���ݒu
            if (pos.z >= 50.0f && first == false)
            {
                //Player�̈ʒu�ɍ��킹��
                Vector3 pos1 = new Vector3(pos.x, -4.42f, 54.75f);
                Vector3 pos2 = new Vector3(pos.x, -7.87f, 60.4f);

                // �v���n�u�𐶐�
                Instantiate(PrefabBrige, pos1, Quaternion.identity);
                Instantiate(PrefabCy, pos2, Quaternion.identity);
                first = true;
            }
        }
    }
}
