using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartFire : MonoBehaviour
{
    [SerializeField] GameObject MainFireworks;
    private int angle;
    private float Fcount;
    private float Ecount;
    private int count;
    private bool fire1;
    private bool fire2;
    public AudioClip Explosion;
    AudioSource audioSource;
    void Start()
    {
        angle = 270;
        Fcount = 0.0f;
        Ecount = 0.0f;
        count = 0;
        fire1 = false;
        fire2 = false;
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Fcount += Time.deltaTime;
        Ecount += Time.deltaTime;
        if (Fcount >= 1.0f)
        {
            count++;
            Fcount = 0.0f;
        }
        if (count == 6)
        {
            count = 0;
            fire1 = false;
            fire2 = false;
            Ecount = 0.0f;
        }
        if (count / 5 == 1 && fire1 == false)
        {
            Instantiate(MainFireworks, this.transform.position, Quaternion.Euler(angle, 0, 0));
            fire1 = true;
        }
        if (Ecount >= 4.5f && fire2 == false)
        {
            audioSource.PlayOneShot(Explosion);
            fire2 = true;
        }
    }
}
