using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGoalFireworks : MonoBehaviour
{
    [SerializeField] GameObject Fireworks1;
    [SerializeField] GameObject Fireworks2;
    [SerializeField] GameObject Fireworks3;
    private int angle;
    private float Fcount;
    private int count;
    private bool fire1;
    private bool fire2;
    private bool fire3;
    void Start()
    {
        angle = 270;
        Fcount = 0.0f;
        count = 0;
        fire1 = false;
        fire2 = false;
        fire3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos1 = new Vector3(16.0f, -14.5f, 50.0f);
        Vector3 pos2 = new Vector3(2.0f, -8.0f, 13.0f);
        Vector3 pos3 = new Vector3(9.5f, -5.0f, 25.5f);
        Fcount += Time.deltaTime;
        if (Fcount >= 1.0f)
        {
            count++;
            Fcount = 0.0f;
        }
        if (count == 7)
        {
            count = 0;
            fire1 = false;
            fire2 = false;
            fire3 = false;

        }
        if (count / 2 == 1 && fire1 == false)
        {
            Instantiate(Fireworks1, pos1, Quaternion.Euler(angle, 0, 0));
            fire1 = true;
        }
        if (count / 4 == 1 && fire2 == false)
        {
            Instantiate(Fireworks2, pos2, Quaternion.Euler(angle, 0, 0));
            fire2 = true;
        }
        if (count / 6 == 1 && fire3 == false)
        {
            Instantiate(Fireworks3, pos3, Quaternion.Euler(angle, 0, 0));
            fire3 = true;
        }
    }
}
