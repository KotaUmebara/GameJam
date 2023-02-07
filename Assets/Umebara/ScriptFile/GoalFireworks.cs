using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalFireworks : MonoBehaviour
{
    [SerializeField] GameObject MainFireworks;
    [SerializeField] GameObject Fireworks1;
    [SerializeField] GameObject Fireworks2;
    [SerializeField] GameObject Fireworks3;
    private int angle;
    void Start()
    {
        angle= 270;
        Instantiate(MainFireworks, this.transform.position, Quaternion.Euler(angle, 0, 0));
        Instantiate(Fireworks1, this.transform.position, Quaternion.Euler(angle, 0, 0));
        Instantiate(Fireworks2, this.transform.position, Quaternion.Euler(angle, 0, 0));
        Instantiate(Fireworks3, this.transform.position, Quaternion.Euler(angle, 0, 0));
    }

    void Update()
    {

    }
}
