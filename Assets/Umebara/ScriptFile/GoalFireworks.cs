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
    private float Ecount;
    private int count;
    private bool fire1;
    private bool fire2;
    private bool fire3;
    private bool fire4;
    private bool fire5;
    private bool fire6;
    private bool Sfire1;
    private bool Sfire2;
    private bool Sfire3;
    private bool Sfire4;
    private bool Sfire5;
    private bool Sfire6;
    private bool Sfire7;
    public AudioClip Explosion;
    public AudioClip Explosion2;
    AudioSource audioSource;
    void Start()
    {
        angle= 270;
        Instantiate(MainFireworks, this.transform.position, Quaternion.Euler(angle, 0, 0));
        Fcount = 0.0f;
        Ecount = 0.0f;
        count = 0;
        fire1 = false;
        fire2 = false;
        fire3 = false;
        fire4 = false;
        fire5 = false;
        fire6 = false;
        Sfire1 = false;
        Sfire2 = false;
        Sfire3 = false;
        Sfire4 = false;
        Sfire5 = false;
        Sfire6 = false;
        Sfire7 = true;
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
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
        Ecount += Time.deltaTime;
        if (Fcount >= 1.0f)
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
            Sfire2 = false;
            Sfire3 = false;
            Sfire4 = false;
            Sfire5 = false;
            Sfire6 = false;
            Sfire7 = false;
            Ecount = 0.0f;
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
        if (Ecount >= 1.5f && Sfire1 == false)
        {
            audioSource.PlayOneShot(Explosion);
            Sfire1 = true;
        }
        if (Ecount >= 2.5f && Sfire2 == false)
        {
            audioSource.PlayOneShot(Explosion2);
            Sfire2 = true;
        }
        if (Ecount >= 3.5f && Sfire3 == false)
        {
            audioSource.PlayOneShot(Explosion2);
            Sfire3 = true;
        }
        if (Ecount >= 4.5f && Sfire4 == false)
        {
            audioSource.PlayOneShot(Explosion2);
            Sfire4 = true;
        }
        if (Ecount >= 5.5f && Sfire5 == false)
        {
            audioSource.PlayOneShot(Explosion2);
            Sfire5 = true;
        }
        if (Ecount >= 6.5f && Sfire6 == false)
        {
            audioSource.PlayOneShot(Explosion2);
            Sfire6 = true;
        }
        if (Ecount >= 0.6f && Sfire7 == false)
        {
            audioSource.PlayOneShot(Explosion2);
            Sfire7 = true;
        }
    }
}
