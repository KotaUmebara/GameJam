using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;
    private bool is_jumpable;
   void FixedUpdate () 
    {
        Rigidbody rb = this.GetComponent<Rigidbody> ();  // rigidbody���擾
        Vector3 force = new Vector3 (0.0f,0.0f,10.0f);    // �͂�ݒ�
        rb.AddForce (force);  // �͂�������
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
        is_jumpable = false;
    }

    // Update is called once per frame
    void Update()
    {
        //�E�ɓ������v���O����
        if (Input.GetKey(KeyCode.A) == true)
        {
            transform.Translate(new Vector3(-0.05f,0,0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(new Vector3(-0.05f, 0, 0));
        }
        //���ɓ������v���O����
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(new Vector3(0.05f, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(new Vector3(0.05f, 0, 0));
        }
        //�W�����v����v���O����
        if (Input.GetKeyDown(KeyCode.Space)&& is_jumpable == true)
        {
            rb.AddForce(new Vector3(0, 800, 0), ForceMode.Force);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        is_jumpable = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        is_jumpable =false;
    }
}

