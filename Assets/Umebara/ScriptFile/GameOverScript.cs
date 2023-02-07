using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text GameOver;
    [SerializeField] GameObject Player;
    private float Gcount;
    void Start()
    {
        //Player�̎擾
        Player = GameObject.Find("Player");
        Gcount = 0.0f;
    }

    void Update()
    {
        if(Player == null)
        {
            Gcount += Time.deltaTime;
            if(Gcount >= 2.25f)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}
