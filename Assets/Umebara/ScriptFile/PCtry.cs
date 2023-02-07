using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCtry : MonoBehaviour
{
    public Rigidbody Trb;
    private bool is_jumpable;
    void FixedUpdate()
    {
        Rigidbody Trb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        Vector3 force = new Vector3(0.0f, 0.0f, 10.0f);    // 力を設定
        Trb.AddForce(force);  // 力を加える
    }
    // Start is called before the first frame update
    void Start()
    {
        Trb = GetComponent<Rigidbody>();
        is_jumpable = false;
    }

    // Update is called once per frame
    void Update()
    {
        //右に動かすプログラム
        if (Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(new Vector3(-0.05f, 0, 0));
        }
        //左に動かすプログラム
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(new Vector3(0.05f, 0, 0));
        }
        //ジャンプするプログラム
        if (Input.GetKeyDown(KeyCode.Space) && is_jumpable == true)
        {
            Trb.AddForce(new Vector3(0, 800, 0), ForceMode.Force);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        is_jumpable = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        is_jumpable = false;
    }
}
