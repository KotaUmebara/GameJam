using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_test : MonoBehaviour
{
    public GameObject hanabiPrefab;
    //角度を決める変数
    Quaternion rot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) //Hを押すと反応
        {
            Instantiate(hanabiPrefab, this.transform.position,rot);
        }
    }
}
