using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFire : MonoBehaviour
{
    [SerializeField] GameObject MainFireworks;
    private int angle;
    private float Fcount;
    private int count;
    private bool fire1;
    void Start()
    {
        angle = 270;
        Fcount = 0.0f;
        count = 0;
        fire1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        Fcount += Time.deltaTime;
        if (Fcount >= 1.0f)
        {
            count++;
            Fcount = 0.0f;
        }
        if (count == 6)
        {
            count = 0;
            fire1 = false;
        }
        if (count / 5 == 1 && fire1 == false)
        {
            Instantiate(MainFireworks, this.transform.position, Quaternion.Euler(angle, 0, 0));
            fire1 = true;
        }
    }
}
