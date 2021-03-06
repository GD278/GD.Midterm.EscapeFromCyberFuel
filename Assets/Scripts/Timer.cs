﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float timer;
    [SerializeField] Text timerTextBox;
    [SerializeField] Text gameOverTextBox;
    [SerializeField] Text replayTextBox;
    bool timeron;
    PlayerController playerController;
    bool gameOver;

    void Start()
    {
        timerTextBox.text = $"{timer}";
        timeron = false;
        replayTextBox.enabled = false;
        gameOver = false;
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            timeron = true;
        }
        if (timeron)
        {
            timer -= Time.deltaTime;
            timerTextBox.text = $"{timer.ToString("F2")}";

            if(timer <= 0)
            {
                timer = 0;
                timerTextBox.text = $"{timer}";
                gameOver = true;
            }

            if (gameOver == true)
            {
                replayTextBox.enabled = true;
                playerController.enabled = false;
                gameOverTextBox.text = "Game Over";
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
        }
    }
}
