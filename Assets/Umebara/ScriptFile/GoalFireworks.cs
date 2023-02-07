using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFireworks : MonoBehaviour
{
    [SerializeField] GameObject MainFireworks;
    [SerializeField] GameObject Fireworks1;
    [SerializeField] GameObject Fireworks2;
    [SerializeField] GameObject Fireworks3;
    [SerializeField] GameObject Fireworks4;
    [SerializeField] GameObject Fireworks5;
    [SerializeField] GameObject Fireworks6;
    private int angle;
    private float Fcount;
    private int count;
    private bool fire1;
    private bool fire2;
    private bool fire3;
    private bool fire4;
    private bool fire5;
    private bool fire6;
    void Start()
    {
        angle= 270;
        Instantiate(MainFireworks, this.transform.position, Quaternion.Euler(angle, 0, 0));
        Fcount = 0.0f;
        count = 0;
        fire1 = false;
        fire2 = false;
        fire3 = false;
        fire4 = false;
        fire5 = false;
        fire6 = false;
    }

    void Update()
    {
        Vector3 pos1 = new Vector3(17.5f, -14.5f, 12.0f);
        Vector3 pos2 = new Vector3(-15.0f, -8.0f, 9.5f);
        Vector3 pos3 = new Vector3(9.5f, -5.0f, 25.5f);
        Vector3 pos4 = new Vector3(-7.65f, -8.0f, 2.35f);
        Vector3 pos5 = new Vector3(13.05f, -0.40f, 12.0f);
        Vector3 pos6 = new Vector3(-14.5f, -5.0f, 14.5f);
        Fcount += Time.deltaTime;
        if(Fcount >= 1.0f)
        {
            count++;
            Fcount= 0.0f;
        }
        if (count == 7)
        {
            count = 0;
            fire1 = false;
            fire2 = false;
            fire3 = false;
            fire4 = false;
            fire5 = false;
            fire6 = false;
        }
        if (count / 1 == 1 && fire1 == false)
        {
            Instantiate(Fireworks1, pos1, Quaternion.Euler(angle, 0, 0));
            fire1= true;
        }
        if (count / 2 == 1 && fire2 == false)
        {
            Instantiate(Fireworks2, pos2, Quaternion.Euler(angle, 0, 0));
            fire2= true;
        }
        if (count / 3 == 1 && fire3 == false)
        {
            Instantiate(Fireworks3, pos3, Quaternion.Euler(angle, 0, 0));
            fire3= true;
        }
        if (count / 4 == 1 && fire4 == false)
        {
            Instantiate(Fireworks1, pos4, Quaternion.Euler(angle, 0, 0));
            fire4 = true;
        }
        if (count / 5 == 1 && fire5 == false)
        {
            Instantiate(Fireworks2, pos5, Quaternion.Euler(angle, 0, 0));
            fire5 = true;
        }
        if (count / 6 == 1 && fire6 == false)
        {
            Instantiate(Fireworks3, pos6, Quaternion.Euler(angle, 0, 0));
            fire6 = true;
        }
    }
}
