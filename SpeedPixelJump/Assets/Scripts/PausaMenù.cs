using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PausaMenù : MonoBehaviour {

    public bool isPaused;
    public GameObject Canvas;
    public bool isClick;


    // Use this for initialization
    void Start()
    {
        isClick = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && isClick == true)
        {

            ChangePauseStatus();

        }

    }

    public void ChangePauseStatus()
    {
        isPaused = !isPaused;
        UpdateGamePause();
    }

    public void UpdateGamePause()
    {
        if (isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
            isClick = false;
           
        }
        else
        {

            Time.timeScale = 1;
            isPaused = false;
            isClick = true;
        }
        Canvas.SetActive(isPaused);

    }
}
