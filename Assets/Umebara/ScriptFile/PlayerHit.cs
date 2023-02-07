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
    //SE�֘A
    public GameObject explosion;
    public AudioClip sound1;
    AudioSource audioSource;
    void Start()
    {
        change = false;
        //Player�̎擾
        Player = GameObject.Find("Player");
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (change == true)
        {
            // transform���擾
            Transform PlayerTransform = this.Player.transform;
            // ���W���擾
            Vector3 pos = PlayerTransform.position;
            Destroy(Player);
            change = false;
            //�����G�t�F�N�g�̈꒲��
            pos.y += 0.8f;
            pos.z -= 0.05f;
            // �v���n�u�𐶐�
            Instantiate(explosion, pos, Quaternion.identity);
            audioSource.PlayOneShot(sound1);
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
