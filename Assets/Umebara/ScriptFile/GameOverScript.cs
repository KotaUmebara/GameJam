using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text GameOver;
    [SerializeField] GameObject Player;
    private bool display;
    void Start()
    {
        //Player�̎擾
        Player = GameObject.Find("Player");
        display = false;
    }

    void Update()
    {
        if(Player == null && display == false)
        {
            GameOver.text = "Game Over";
            display = true;
        }
    }
}
