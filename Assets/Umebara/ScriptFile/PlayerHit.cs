using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerHit : MonoBehaviour
{
    //���딻��
    private bool change;
    //Player�̊i�[
    GameObject Player;
    // ��������v���n�u�i�[�p
    public GameObject explosion;
    Vector3 pos;
    void Start()
    {
        change = false;
        //Player�̎擾
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Player != null)
        {
            // transform���擾
            Transform PlayerTransform = this.Player.transform;
            // ���W���擾
            Vector3 pos = PlayerTransform.position;
        }
        if (change == true)
        {
            Destroy(Player);
            change = false;
            // �v���n�u�𐶐�
            Instantiate(explosion, pos, Quaternion.identity);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Player")
        {
            // ����̐؂�ւ�
            change = true;
        }
    }
}
