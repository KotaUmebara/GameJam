using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    //���딻��
    private bool change;
    //Player�̊i�[
    [SerializeField] GameObject Player;
    void Start()
    {
        change = false;
        //Player�̎擾
        Player = GameObject.Find("Player");

    }

    void Update()
    {
        //���낪�؂�ւ������V�[���J��
        if (change == true)
        {
            SceneManager.LoadScene("NewGoalScene");
            change = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Player")
        {
            // ����̐؂�ւ�
            change= true;
        }
    }
}
